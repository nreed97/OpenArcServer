namespace OpenArcServer.Engine.Spots;

/// <summary>
/// Great-circle distance, initial bearing, and Maidenhead grid locator conversions.
/// All angles are in degrees unless otherwise noted.
/// </summary>
public static class GeoCalculator
{
    private const double EarthRadiusKm = 6371.0;

    /// <summary>Great-circle distance in kilometres between two lat/lon points.</summary>
    public static double DistanceKm(double lat1, double lon1, double lat2, double lon2)
    {
        var dLat = ToRad(lat2 - lat1);
        var dLon = ToRad(lon2 - lon1);
        var a    = Math.Sin(dLat / 2) * Math.Sin(dLat / 2)
                 + Math.Cos(ToRad(lat1)) * Math.Cos(ToRad(lat2))
                 * Math.Sin(dLon / 2)   * Math.Sin(dLon / 2);
        return EarthRadiusKm * 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
    }

    /// <summary>Initial bearing (degrees true, 0–360) from point 1 to point 2.</summary>
    public static double BearingDeg(double lat1, double lon1, double lat2, double lon2)
    {
        var dLon = ToRad(lon2 - lon1);
        var φ1   = ToRad(lat1);
        var φ2   = ToRad(lat2);
        var y    = Math.Sin(dLon) * Math.Cos(φ2);
        var x    = Math.Cos(φ1) * Math.Sin(φ2) - Math.Sin(φ1) * Math.Cos(φ2) * Math.Cos(dLon);
        return (ToDeg(Math.Atan2(y, x)) + 360) % 360;
    }

    /// <summary>
    /// Converts a Maidenhead grid locator (4- or 6-character) to latitude/longitude.
    /// Returns the centre of the square/sub-square.
    /// </summary>
    public static bool TryParseGrid(string grid, out double lat, out double lon)
    {
        lat = lon = 0;
        if (string.IsNullOrWhiteSpace(grid) || grid.Length < 4) return false;

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
            lon += (g[4] - 'A') * (2.0 / 24.0) + (1.0 / 24.0);  // centre of sub-square
            lat += (g[5] - 'A') * (1.0 / 24.0) + (0.5 / 24.0);
        }
        else
        {
            lon += 1.0;   // centre of square
            lat += 0.5;
        }

        return true;
    }

    public static double ToRad(double deg) => deg * Math.PI / 180.0;
    public static double ToDeg(double rad) => rad * 180.0 / Math.PI;
}
