using Microsoft.Extensions.Logging;
using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Engine.Commands;

// ---------------------------------------------------------------------------
// WX <message>  — post a weather announcement broadcast to all users
// ---------------------------------------------------------------------------
public sealed class WxCommand : IArcCommand
{
    private readonly IWxRepository _repo;
    private readonly ILogger<WxCommand> _log;

    public WxCommand(IWxRepository repo, ILogger<WxCommand> log)
    {
        _repo = repo;
        _log = log;
    }

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var req = context.Request;
        var session = context.Session;
        var resp = context.Response;

        var raw = req.RawMessage.Trim();
        if (raw.StartsWith("WX", StringComparison.OrdinalIgnoreCase))
            raw = raw[2..].TrimStart();

        if (string.IsNullOrWhiteSpace(raw))
        {
            resp.Messages.Add("Usage: WX <weather message>  (e.g. WX Sunny and warm, winds SW 10 mph)");
            resp.DistroType = DistroType.ToRequester;
            return;
        }

        var now = DateTime.UtcNow;
        var spot = new WxSpot
        {
            Message = raw,
            Spotter = session.Callsign,
            SpotterNode = string.Empty,
            Timestamp = now,
        };

        await _repo.InsertAsync(spot, ct);
        _log.LogInformation("WX: {Spotter}: {Message}", session.Callsign, raw);

        resp.Messages.Add(WxFormatter.Format(spot));
        resp.DistroType = DistroType.ToAll;
        resp.MsgType = MsgType.Wx;
    }
}

// ---------------------------------------------------------------------------
// SH/WX [n]  — show the last n weather reports (default 5)
// ---------------------------------------------------------------------------
public sealed class ShowWxCommand : IArcCommand
{
    private readonly IWxRepository _repo;

    public ShowWxCommand(IWxRepository repo) => _repo = repo;

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var tokens = context.Request.Tokens;
        var resp = context.Response;

        int count = 5;
        int wxIdx = Array.FindIndex(tokens, t => t.Equals("WX", StringComparison.OrdinalIgnoreCase));
        if (wxIdx >= 0 && wxIdx + 1 < tokens.Length
            && int.TryParse(tokens[wxIdx + 1], out var n))
            count = Math.Clamp(n, 1, 50);

        var spots = await _repo.GetRecentAsync(count, ct);
        if (spots.Count == 0)
            resp.Messages.Add("No WX reports on file.");
        else
            foreach (var s in spots)
                resp.Messages.Add(WxFormatter.Format(s));

        resp.DistroType = DistroType.ToRequester;
        resp.MsgType = MsgType.Wx;
    }
}

// ---------------------------------------------------------------------------
// Formatter
// Output: "WX de W1AW    <14-FEB-2024>: Sunny and warm, winds SW                1530Z"
// ---------------------------------------------------------------------------
file static class WxFormatter
{
    public static string Format(WxSpot s)
    {
        var date = s.Timestamp.ToString("dd-MMM-yyyy").ToUpper();
        var time = s.Timestamp.ToString("HHmm") + "Z";
        var body = $"WX de {s.Spotter,-10} <{date}>: {s.Message}";
        return $"{body,-72}{time}";
    }
}
