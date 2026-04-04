using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Services;
using OpenArcServer.Engine.Spots;

namespace OpenArcServer.Engine.Commands;

/// <summary>
/// Handles: SH/DX [n] [call]
/// Shows the most recent DX spots (optionally filtered by callsign prefix).
/// </summary>
public sealed class ShowDxCommand : IArcCommand
{
    private readonly IDxSpotRepository _spots;

    public ShowDxCommand(IDxSpotRepository spots)
    {
        _spots = spots;
    }

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var tokens = context.Request.Tokens;
        var session = context.Session;
        var resp = context.Response;

        // SH/DX [n] [call]  — tokens[0] is "SH", tokens[1] is "DX", tokens[2+] are args
        int count = session.DxCount;
        string? callFilter = null;

        // Parse args after "SH DX"
        int argStart = Array.IndexOf(tokens, "DX") + 1;
        if (argStart < tokens.Length)
        {
            // Could be: SH/DX 20  or  SH/DX W1AW  or  SH/DX 20 W1AW
            if (int.TryParse(tokens[argStart], out var n))
            {
                count = Math.Clamp(n, 1, 100);
                if (argStart + 1 < tokens.Length)
                    callFilter = tokens[argStart + 1].ToUpperInvariant();
            }
            else
            {
                callFilter = tokens[argStart].ToUpperInvariant();
            }
        }

        IReadOnlyList<Core.Models.DxSpot> spots;
        if (!string.IsNullOrEmpty(callFilter))
            spots = await _spots.SearchByCallAsync(callFilter, count, ct);
        else
            spots = await _spots.GetRecentAsync(count, ct);

        if (spots.Count == 0)
        {
            resp.Messages.Add("No spots found.");
        }
        else
        {
            foreach (var line in DxSpotFormatter.FormatList(spots))
                resp.Messages.Add(line);
        }

        resp.DistroType = DistroType.ToRequester;
        resp.MsgType = MsgType.Dx;
    }
}
