using OpenArcServer.Core;
using OpenArcServer.Core.Commands;

namespace OpenArcServer.Engine.Commands;

/// <summary>
/// Handles: SH/SOLAR — grayline / solar position information.
///
/// If the user's session has a Maidenhead grid square set (via SET/GRID), local
/// sunrise and sunset times are calculated for their location.  Otherwise, only
/// the sub-solar point and grey-line positions are shown.
///
/// Calculation: simplified NOAA Solar Position Algorithm accurate to ±1–2 min.
/// </summary>
public sealed class ShowSolarCommand : IArcCommand
{
    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var now  = DateTime.UtcNow;
        var resp = context.Response;

        // Sub-solar point (the point on Earth where the sun is directly overhead)
        var (subLat, subLon) = SubSolarPoint(now);
        var subLonStr = $"{Math.Abs(subLon):F1}{(subLon >= 0 ? "E" : "W")}";
        var subLatStr = $"{Math.Abs(subLat):F1}{(subLat >= 0 ? "N" : "S")}";

        // Grey-line longitudes at the equator (approximately sunrise/sunset longitude)
        // Sunrise terminator is 90° west of sub-solar point; sunset terminator is 90° east
        var riseTermLon = NormalizeLon(subLon - 90.0);
        var setTermLon  = NormalizeLon(subLon + 90.0);

        resp.Messages.Add($"Solar/Grayline info — {now:dd-MMM-yyyy HHmmZ}");
        resp.Messages.Add($"  Sub-solar point : {subLatStr} {subLonStr}");
        resp.Messages.Add($"  Grayline (rise) : {LonToStr(riseTermLon),8}  (sunrise terminator, equator)");
        resp.Messages.Add($"  Grayline (set)  : {LonToStr(setTermLon),8}  (sunset terminator, equator)");

        // If user has a grid square, show local sunrise/sunset
        var grid = context.Session.Grid;
        if (!string.IsNullOrWhiteSpace(grid) && TryParseGrid(grid, out var lat, out var lon))
        {
            var (sunrise, sunset) = SunriseSunset(lat, lon, now);
            var daylight = IsDaylight(lat, lon, now, sunrise, sunset);

            resp.Messages.Add(string.Empty);
            resp.Messages.Add($"  Your location   : {grid.ToUpperInvariant()}  ({Math.Abs(lat):F1}{(lat >= 0 ? "N" : "S")} {Math.Abs(lon):F1}{(lon >= 0 ? "E" : "W")})");
            resp.Messages.Add($"  Status          : {(daylight ? "DAYLIGHT" : "DARKNESS")}");

            if (sunrise.HasValue && sunset.HasValue)
            {
                resp.Messages.Add($"  Sunrise         : {sunrise.Value:HHmmZ}");
                resp.Messages.Add($"  Sunset          : {sunset.Value:HHmmZ}");
            }
            else if (sunrise is null && sunset is null)
            {
                // Determine if polar day or polar night
                resp.Messages.Add(daylight
                    ? "  (Polar day — sun does not set)"
                    : "  (Polar night — sun does not rise)");
            }
        }
        else
        {
            resp.Messages.Add(string.Empty);
            resp.Messages.Add("  Tip: SET/GRID <locator> to see your local sunrise/sunset.");
        }

        resp.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }

    // ── Solar calculations ──────────────────────────────────────────────────

    /// <summary>
    /// Returns the sub-solar point (lat, lon) in degrees for the given UTC instant.
    /// Uses a simplified version of the VSOP87 / Meeus algorithm (accuracy ~0.01°).
    /// </summary>
    private static (double Lat, double Lon) SubSolarPoint(DateTime utc)
    {
        var jd = ToJulian(utc);
        var T  = (jd - 2451545.0) / 36525.0; // Julian centuries from J2000.0

        // Geometric mean longitude of the sun (°)
        var L0 = Mod360(280.46646 + 36000.76983 * T + 0.0003032 * T * T);

        // Mean anomaly (°)
        var M    = Mod360(357.52911 + 35999.05029 * T - 0.0001537 * T * T);
        var Mrad = ToRad(M);

        // Equation of center (°)
        var C = (1.914602 - 0.004817 * T - 0.000014 * T * T) * Math.Sin(Mrad)
              + (0.019993 - 0.000101 * T) * Math.Sin(2 * Mrad)
              + 0.000289 * Math.Sin(3 * Mrad);

        // Sun's true longitude (°)
        var sunL = L0 + C;

        // Apparent longitude (°) — nutation & aberration correction
        var omega   = Mod360(125.04 - 1934.136 * T);
        var lambdaD = sunL - 0.00569 - 0.00478 * Math.Sin(ToRad(omega));
        var lambdaR = ToRad(lambdaD);

        // Mean obliquity of ecliptic (°)
        var eMean = 23.0 + 26.0 / 60.0 + 21.448 / 3600.0
                  - (46.815 * T + 0.00059 * T * T - 0.001813 * T * T * T) / 3600.0;
        // True obliquity
        var eps  = eMean + 0.00256 * Math.Cos(ToRad(omega));
        var epsR = ToRad(eps);

        // Solar declination (° = sub-solar latitude)
        var decR = Math.Asin(Math.Sin(epsR) * Math.Sin(lambdaR));
        var dec  = ToDeg(decR);

        // Right ascension (°)
        var raR = Math.Atan2(Math.Cos(epsR) * Math.Sin(lambdaR), Math.Cos(lambdaR));
        var ra  = Mod360(ToDeg(raR));

        // Greenwich Apparent Sidereal Time (°)
        var GAST = Mod360(280.46061837
                        + 360.98564736629 * (jd - 2451545.0)
                        + 0.000387933 * T * T
                        - T * T * T / 38710000.0);

        // Sub-solar longitude = RA - GAST
        var subLon = NormalizeLon(ra - GAST);

        return (dec, subLon);
    }

    /// <summary>
    /// Calculates sunrise and sunset times (UTC) for a given location and date.
    /// Returns (null, null) on polar day or polar night.
    /// </summary>
    private static (DateTime? Sunrise, DateTime? Sunset) SunriseSunset(
        double lat, double lon, DateTime utc)
    {
        var jd = ToJulian(utc.Date.AddHours(12)); // Julian noon
        var T  = (jd - 2451545.0) / 36525.0;

        // Simplified: sun's declination at noon UTC for this date
        var M    = Mod360(357.52911 + 35999.05029 * T);
        var Mrad = ToRad(M);
        var C    = 1.914602 * Math.Sin(Mrad) + 0.019993 * Math.Sin(2 * Mrad);
        var L0   = Mod360(280.46646 + 36000.76983 * T);
        var sunL = L0 + C;
        var eps  = 23.439 - 0.0000004 * (jd - 2451545.0);
        var decR = Math.Asin(Math.Sin(ToRad(eps)) * Math.Sin(ToRad(sunL)));

        // Hour angle at sunrise/sunset (standard 90.833° zenith includes refraction + solar disk)
        var cosHA = (Math.Cos(ToRad(90.833)) - Math.Sin(ToRad(lat)) * Math.Sin(decR))
                  / (Math.Cos(ToRad(lat)) * Math.Cos(decR));

        if (cosHA > 1.0) return (null, null); // polar night
        if (cosHA < -1.0) return (null, null); // polar day

        var HA = ToDeg(Math.Acos(cosHA)); // degrees (0-180)

        // Equation of time (minutes) — simplified
        var y   = Math.Pow(Math.Tan(ToRad(eps / 2)), 2);
        var eot = 4.0 * ToDeg(
            y * Math.Sin(2 * ToRad(L0))
            - 2 * 0.016709 * Math.Sin(Mrad)
            + 4 * 0.016709 * y * Math.Sin(Mrad) * Math.Cos(2 * ToRad(L0))
            - 0.5 * y * y * Math.Sin(4 * ToRad(L0))
            - 1.25 * 0.016709 * 0.016709 * Math.Sin(2 * Mrad));

        // Solar noon in minutes past midnight UTC at the given longitude
        var solarNoonMin = 720 - 4 * lon - eot;

        var sunriseMin = solarNoonMin - HA * 4;
        var sunsetMin  = solarNoonMin + HA * 4;

        var date = utc.Date;
        return (date.AddMinutes(sunriseMin), date.AddMinutes(sunsetMin));
    }

    /// <summary>Returns true if the given location is currently in daylight.</summary>
    private static bool IsDaylight(double lat, double lon, DateTime utc,
        DateTime? sunrise, DateTime? sunset)
    {
        if (sunrise is null || sunset is null)
        {
            // Polar region: check if sun is above horizon (declination same sign as lat)
            var (subLat, _) = SubSolarPoint(utc);
            return (lat >= 0 && subLat >= 0) || (lat < 0 && subLat < 0);
        }

        return utc >= sunrise.Value && utc <= sunset.Value;
    }

    // ── Maidenhead grid locator → lat/lon ───────────────────────────────────

    private static bool TryParseGrid(string grid, out double lat, out double lon)
    {
        lat = lon = 0;
        if (grid.Length < 4) return false;

        var g = grid.ToUpperInvariant();
        if (g[0] < 'A' || g[0] > 'R') return false;
        if (g[1] < 'A' || g[1] > 'R') return false;
        if (g[2] < '0' || g[2] > '9') return false;
        if (g[3] < '0' || g[3] > '9') return false;

        lon = (g[0] - 'A') * 20.0 - 180.0;
        lat = (g[1] - 'A') * 10.0 - 90.0;
        lon += (g[2] - '0') * 2.0;
        lat += (g[3] - '0') * 1.0;

        if (g.Length >= 6 && g[4] >= 'A' && g[4] <= 'X' && g[5] >= 'A' && g[5] <= 'X')
        {
            lon += (g[4] - 'A') * (2.0 / 24.0);
            lat += (g[5] - 'A') * (1.0 / 24.0);
            // Centre of the sub-square
            lon += 1.0 / 24.0;
            lat += 0.5 / 24.0;
        }
        else
        {
            // Centre of the square
            lon += 1.0;
            lat += 0.5;
        }

        return true;
    }

    // ── Math helpers ────────────────────────────────────────────────────────

    private static double ToJulian(DateTime utc)
    {
        // Algorithm from Jean Meeus "Astronomical Algorithms"
        var y  = utc.Year;
        var m  = utc.Month;
        var d  = utc.Day + utc.TimeOfDay.TotalDays;
        if (m <= 2) { y--; m += 12; }
        var A = (int)(y / 100.0);
        var B = 2 - A + (int)(A / 4.0);
        return (int)(365.25 * (y + 4716)) + (int)(30.6001 * (m + 1)) + d + B - 1524.5;
    }

    private static double ToRad(double deg) => deg * Math.PI / 180.0;
    private static double ToDeg(double rad) => rad * 180.0 / Math.PI;
    private static double Mod360(double d) => ((d % 360.0) + 360.0) % 360.0;

    private static double NormalizeLon(double lon)
    {
        lon = ((lon % 360.0) + 360.0) % 360.0;
        return lon > 180.0 ? lon - 360.0 : lon;
    }

    private static string LonToStr(double lon)
    {
        lon = NormalizeLon(lon);
        return $"{Math.Abs(lon):F1}{(lon >= 0 ? "E" : "W")}";
    }
}
