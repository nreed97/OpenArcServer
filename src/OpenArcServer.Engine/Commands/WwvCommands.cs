using Microsoft.Extensions.Logging;
using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Engine.Commands;

// ---------------------------------------------------------------------------
// WWV <sfi> <a> <k> [forecast text]
// Post a WWV solar/geomagnetic propagation report.
// ---------------------------------------------------------------------------
public sealed class WwvCommand : IArcCommand
{
    private readonly IWwvRepository _repo;
    private readonly ILogger<WwvCommand> _log;

    public WwvCommand(IWwvRepository repo, ILogger<WwvCommand> log)
    {
        _repo = repo;
        _log = log;
    }

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var req = context.Request;
        var session = context.Session;
        var resp = context.Response;

        // Tokens: [WWV, <sfi>, <a>, <k>, ...forecast...]
        // Accept both space and comma-separated: "WWV 150 5 2 No Storms" or "WWV 150,5,2,No Storms"
        var raw = req.RawMessage.Trim();
        if (raw.StartsWith("WWV", StringComparison.OrdinalIgnoreCase))
            raw = raw[3..].TrimStart();

        // Normalise commas to spaces for uniform parsing
        var parts = raw.Replace(',', ' ')
                       .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length < 3)
        {
            resp.Messages.Add("Usage: WWV <sfi> <a> <k> [forecast]  (e.g. WWV 150 5 2 No Storms)");
            resp.DistroType = DistroType.ToRequester;
            return;
        }

        var sfi = parts[0];
        var a   = parts[1];
        var k   = parts[2];
        var forecast = parts.Length > 3 ? string.Join(" ", parts[3..]) : string.Empty;

        // Basic validation: SFI, A, K should be numeric
        if (!int.TryParse(sfi, out _) || !int.TryParse(a, out _) || !int.TryParse(k, out _))
        {
            resp.Messages.Add("SFI, A, and K must be numbers.  Example: WWV 150 5 2 No Storms");
            resp.DistroType = DistroType.ToRequester;
            return;
        }

        var now = DateTime.UtcNow;
        var spot = new WwvSpot
        {
            Sfi = sfi,
            A = a,
            K = k,
            Forecast = forecast,
            Spotter = session.Callsign,
            SpotterNode = string.Empty,
            Timestamp = now,
        };

        await _repo.InsertAsync(spot, ct);
        _log.LogInformation("WWV: {Spotter} SFI={Sfi} A={A} K={K}", session.Callsign, sfi, a, k);

        resp.Messages.Add(WwvFormatter.Format(spot));
        resp.DistroType = DistroType.ToAll;
        resp.MsgType = MsgType.Wwv;
    }
}

// ---------------------------------------------------------------------------
// SH/WWV [n]  — show the last n WWV reports (default 5)
// ---------------------------------------------------------------------------
public sealed class ShowWwvCommand : IArcCommand
{
    private readonly IWwvRepository _repo;

    public ShowWwvCommand(IWwvRepository repo) => _repo = repo;

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var tokens = context.Request.Tokens;
        var resp = context.Response;

        // SH/WWV [n]  — token after "WWV" is optional count
        int count = 5;
        int wwvIdx = Array.FindIndex(tokens, t => t.Equals("WWV", StringComparison.OrdinalIgnoreCase));
        if (wwvIdx >= 0 && wwvIdx + 1 < tokens.Length
            && int.TryParse(tokens[wwvIdx + 1], out var n))
            count = Math.Clamp(n, 1, 50);

        var spots = await _repo.GetRecentAsync(count, ct);
        if (spots.Count == 0)
            resp.Messages.Add("No WWV reports on file.");
        else
            foreach (var s in spots)
                resp.Messages.Add(WwvFormatter.Format(s));

        resp.DistroType = DistroType.ToRequester;
        resp.MsgType = MsgType.Wwv;
    }
}

// ---------------------------------------------------------------------------
// Formatter
// Output: "WWV de W1AW  <14-Feb-2024>: SFI=150, A=5, K=2, No Storms             1530Z"
// ---------------------------------------------------------------------------
file static class WwvFormatter
{
    public static string Format(WwvSpot s)
    {
        var date = s.Timestamp.ToString("dd-MMM-yyyy").ToUpper();
        var time = s.Timestamp.ToString("HHmm") + "Z";

        var forecast = string.IsNullOrWhiteSpace(s.Forecast) ? string.Empty : $", {s.Forecast}";
        var body = $"WWV de {s.Spotter,-10} <{date}>: SFI={s.Sfi}, A={s.A}, K={s.K}{forecast}";
        return $"{body,-72}{time}";
    }
}
