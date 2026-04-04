using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Engine.Commands;

// ---------------------------------------------------------------------------
// SET/DX/BAND <bands>   — e.g. "SET/DX/BAND 20m 40m 15m"
// ---------------------------------------------------------------------------
public sealed class SetDxBandCommand : IArcCommand
{
    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        // Tokens: [SET, DX, BAND, <band1>, <band2>, ...]
        var args = FilterCommandHelpers.ArgsAfter(context.Request.Tokens, "BAND");
        if (args.Length == 0)
        {
            context.Response.Messages.Add("Usage: SET/DX/BAND <band> [band ...]  (e.g. SET/DX/BAND 20m 40m)");
            context.Response.DistroType = DistroType.ToRequester;
            return Task.CompletedTask;
        }

        var bands = new HashSet<float>();
        var rejected = new List<string>();
        foreach (var a in args)
        {
            var v = SpotFilter.ParseBand(a);
            if (v.HasValue) bands.Add(v.Value);
            else rejected.Add(a);
        }

        if (bands.Count == 0)
        {
            context.Response.Messages.Add($"No valid band values. Try: 160m 80m 40m 30m 20m 17m 15m 12m 10m 6m 2m");
            context.Response.DistroType = DistroType.ToRequester;
            return Task.CompletedTask;
        }

        context.Session.SpotFilter.Bands = bands;
        var msg = $"Band filter set to: {string.Join(" ", bands.Order().Select(b => b + "m"))}";
        if (rejected.Count > 0) msg += $"  (ignored: {string.Join(" ", rejected)})";
        context.Response.Messages.Add(msg);
        context.Response.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}

// ---------------------------------------------------------------------------
// SET/DX/NOBAND — clear band filter
// ---------------------------------------------------------------------------
public sealed class SetDxNoBandCommand : IArcCommand
{
    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        context.Session.SpotFilter.Bands = null;
        context.Response.Messages.Add("Band filter cleared — receiving spots on all bands.");
        context.Response.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}

// ---------------------------------------------------------------------------
// SET/DX/MODE <modes>   — e.g. "SET/DX/MODE CW SSB"
// ---------------------------------------------------------------------------
public sealed class SetDxModeCommand : IArcCommand
{
    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var args = FilterCommandHelpers.ArgsAfter(context.Request.Tokens, "MODE");
        if (args.Length == 0)
        {
            context.Response.Messages.Add("Usage: SET/DX/MODE <mode> [mode ...]  (e.g. SET/DX/MODE CW SSB)");
            context.Response.DistroType = DistroType.ToRequester;
            return Task.CompletedTask;
        }

        var modes = new HashSet<string>(args.Select(a => a.ToUpperInvariant()), StringComparer.OrdinalIgnoreCase);
        context.Session.SpotFilter.Modes = modes;
        context.Response.Messages.Add($"Mode filter set to: {string.Join(" ", modes)}");
        context.Response.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}

// ---------------------------------------------------------------------------
// SET/DX/NOMODE — clear mode filter
// ---------------------------------------------------------------------------
public sealed class SetDxNoModeCommand : IArcCommand
{
    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        context.Session.SpotFilter.Modes = null;
        context.Response.Messages.Add("Mode filter cleared — receiving spots on all modes.");
        context.Response.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}

// ---------------------------------------------------------------------------
// SET/DX/CONT <continents>   — e.g. "SET/DX/CONT EU NA"
// Valid codes: NA SA EU AF AS OC AN
// ---------------------------------------------------------------------------
public sealed class SetDxContCommand : IArcCommand
{
    private static readonly HashSet<string> ValidConts =
        new(StringComparer.OrdinalIgnoreCase) { "NA", "SA", "EU", "AF", "AS", "OC", "AN" };

    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var args = FilterCommandHelpers.ArgsAfter(context.Request.Tokens, "CONT");
        if (args.Length == 0)
        {
            context.Response.Messages.Add("Usage: SET/DX/CONT <cont> [cont ...]  (NA SA EU AF AS OC AN)");
            context.Response.DistroType = DistroType.ToRequester;
            return Task.CompletedTask;
        }

        var valid = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        var rejected = new List<string>();
        foreach (var a in args)
        {
            if (ValidConts.Contains(a)) valid.Add(a.ToUpperInvariant());
            else rejected.Add(a);
        }

        if (valid.Count == 0)
        {
            context.Response.Messages.Add($"No valid continent codes. Use: NA SA EU AF AS OC AN");
            context.Response.DistroType = DistroType.ToRequester;
            return Task.CompletedTask;
        }

        context.Session.SpotFilter.Continents = valid;
        var msg = $"Continent filter set to: {string.Join(" ", valid)}";
        if (rejected.Count > 0) msg += $"  (ignored: {string.Join(" ", rejected)})";
        context.Response.Messages.Add(msg);
        context.Response.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}

// ---------------------------------------------------------------------------
// SET/DX/NOCONT — clear continent filter
// ---------------------------------------------------------------------------
public sealed class SetDxNoContCommand : IArcCommand
{
    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        context.Session.SpotFilter.Continents = null;
        context.Response.Messages.Add("Continent filter cleared — receiving spots from all continents.");
        context.Response.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}

// ---------------------------------------------------------------------------
// SET/DX/CQ <zones>   — e.g. "SET/DX/CQ 14 25 3"
// ---------------------------------------------------------------------------
public sealed class SetDxCqCommand : IArcCommand
{
    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var args = FilterCommandHelpers.ArgsAfter(context.Request.Tokens, "CQ");
        if (args.Length == 0)
        {
            context.Response.Messages.Add("Usage: SET/DX/CQ <zone> [zone ...]  (CQ zones 1-40)");
            context.Response.DistroType = DistroType.ToRequester;
            return Task.CompletedTask;
        }

        var zones = new HashSet<int>();
        var rejected = new List<string>();
        foreach (var a in args)
        {
            if (int.TryParse(a, out var z) && z >= 1 && z <= 40)
                zones.Add(z);
            else
                rejected.Add(a);
        }

        if (zones.Count == 0)
        {
            context.Response.Messages.Add("No valid CQ zone numbers (must be 1-40).");
            context.Response.DistroType = DistroType.ToRequester;
            return Task.CompletedTask;
        }

        context.Session.SpotFilter.CqZones = zones;
        var msg = $"CQ zone filter set to: {string.Join(" ", zones.Order())}";
        if (rejected.Count > 0) msg += $"  (ignored: {string.Join(" ", rejected)})";
        context.Response.Messages.Add(msg);
        context.Response.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}

// ---------------------------------------------------------------------------
// SET/DX/NOCQ — clear CQ zone filter
// ---------------------------------------------------------------------------
public sealed class SetDxNoCqCommand : IArcCommand
{
    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        context.Session.SpotFilter.CqZones = null;
        context.Response.Messages.Add("CQ zone filter cleared — receiving spots from all zones.");
        context.Response.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}

// ---------------------------------------------------------------------------
// SH/FILTER — show current filter settings
// ---------------------------------------------------------------------------
public sealed class ShowFilterCommand : IArcCommand
{
    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        context.Response.Messages.Add(context.Session.SpotFilter.Describe());
        context.Response.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}

// ---------------------------------------------------------------------------
// Shared helper
// ---------------------------------------------------------------------------
file static class FilterCommandHelpers
{
    /// <summary>Returns tokens that appear after the first occurrence of <paramref name="marker"/>.</summary>
    public static string[] ArgsAfter(string[] tokens, string marker)
    {
        var idx = Array.FindIndex(tokens, t => t.Equals(marker, StringComparison.OrdinalIgnoreCase));
        return idx >= 0 && idx + 1 < tokens.Length
            ? tokens[(idx + 1)..]
            : Array.Empty<string>();
    }
}
