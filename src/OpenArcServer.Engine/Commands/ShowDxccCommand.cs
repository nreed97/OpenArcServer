using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Services;
using OpenArcServer.Engine.Spots;

namespace OpenArcServer.Engine.Commands;

/// <summary>
/// Handles: SH/DXCC &lt;call&gt;  and  SH/PREFIX &lt;call&gt;
///
/// Resolves a callsign or prefix to its DXCC entity and shows:
///   Country name, CTY code, continent, CQ zone, ITU zone
///   If the user has SET/GRID: bearing (°) and distance (km) to the entity's nominal position
/// </summary>
public sealed class ShowDxccCommand : IArcCommand
{
    private readonly ICtyLookup _cty;

    public ShowDxccCommand(ICtyLookup cty)
    {
        _cty = cty;
    }

    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var tokens = context.Request.Tokens;
        var resp   = context.Response;

        // SH/DXCC <call>  or  SH/PREFIX <call>
        // Find the keyword index, then take the next token as the query
        int kwIdx = -1;
        for (int i = 0; i < tokens.Length; i++)
        {
            if (tokens[i].Equals("DXCC",   StringComparison.OrdinalIgnoreCase) ||
                tokens[i].Equals("PREFIX", StringComparison.OrdinalIgnoreCase))
            {
                kwIdx = i;
                break;
            }
        }

        if (kwIdx < 0 || kwIdx + 1 >= tokens.Length)
        {
            resp.Messages.Add("Usage: SH/DXCC <callsign>  e.g. SH/DXCC JA1YAD");
            resp.DistroType = DistroType.ToRequester;
            return Task.CompletedTask;
        }

        var query  = tokens[kwIdx + 1].ToUpperInvariant();
        var record = _cty.LookupCallsign(query);

        if (record is null)
        {
            resp.Messages.Add($"No DXCC data found for: {query}");
            resp.DistroType = DistroType.ToRequester;
            return Task.CompletedTask;
        }

        resp.Messages.Add($"DXCC lookup: {query}");
        resp.Messages.Add($"  Country   : {record.CountryName}");
        resp.Messages.Add($"  CTY code  : {record.CtyCode}");
        resp.Messages.Add($"  Continent : {record.Continent}");
        resp.Messages.Add($"  CQ zone   : {record.CqZone}");
        resp.Messages.Add($"  ITU zone  : {record.ItuZone}");
        resp.Messages.Add($"  Lat/Lon   : {Math.Abs(record.Latitude):F1}{(record.Latitude >= 0 ? "N" : "S")} " +
                          $"{Math.Abs(record.Longitude):F1}{(record.Longitude >= 0 ? "E" : "W")}");

        // Show bearing/distance if user has a grid square
        if (!string.IsNullOrEmpty(context.Session.Grid) &&
            GeoCalculator.TryParseGrid(context.Session.Grid, out var userLat, out var userLon))
        {
            var dist    = GeoCalculator.DistanceKm(userLat, userLon, record.Latitude, record.Longitude);
            var bearing = GeoCalculator.BearingDeg(userLat, userLon, record.Latitude, record.Longitude);
            resp.Messages.Add($"  From {context.Session.Grid,-6}  : {bearing:F0}°  {dist:F0} km");
        }
        else
        {
            resp.Messages.Add("  (SET/GRID <locator> to see bearing/distance from your QTH)");
        }

        resp.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}
