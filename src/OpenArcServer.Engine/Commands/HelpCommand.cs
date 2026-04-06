using OpenArcServer.Core;
using OpenArcServer.Core.Commands;

namespace OpenArcServer.Engine.Commands;

/// <summary>Handles: HELP — lists available commands.</summary>
public sealed class HelpCommand : IArcCommand
{
    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var resp = context.Response;
        resp.Messages.Add("Commands available:");
        resp.Messages.Add("  DX <freq> <call> [comment]       - Post a DX spot");
        resp.Messages.Add("  SH/DX [n] [call]                 - Show last n DX spots (default 10)");
        resp.Messages.Add("  SH/U                             - Show connected users");
        resp.Messages.Add("  SH/N                             - Show connected cluster nodes");
        resp.Messages.Add("  SH/VERSION                       - Show server version");
        resp.Messages.Add("  SH/TIME                          - Show current UTC time");
        resp.Messages.Add("  SH/FILTER                        - Show your current spot filters");
        resp.Messages.Add("  SET/DX/BAND <bands>              - Filter by band (e.g. 20m 40m 15m)");
        resp.Messages.Add("  SET/DX/NOBAND                    - Clear band filter");
        resp.Messages.Add("  SET/DX/MODE <modes>              - Filter by mode (CW SSB RTTY FT8 ...)");
        resp.Messages.Add("  SET/DX/NOMODE                    - Clear mode filter");
        resp.Messages.Add("  SET/DX/CONT <conts>              - Filter by continent (NA EU AF AS SA OC AN)");
        resp.Messages.Add("  SET/DX/NOCONT                    - Clear continent filter");
        resp.Messages.Add("  SET/DX/CQ <zones>                - Filter by CQ zone (1-40)");
        resp.Messages.Add("  SET/DX/NOCQ                      - Clear CQ zone filter");
        resp.Messages.Add("  SET/NAME <name>                  - Set your operator name");
        resp.Messages.Add("  SET/QTH <location>               - Set your QTH");
        resp.Messages.Add("  SET/GRID <grid>                  - Set your Maidenhead grid (e.g. FN42)");
        resp.Messages.Add("  SET/EMAIL <address>              - Set your email address");
        resp.Messages.Add("  SET/DXCOUNT <n>                  - Set default SH/DX spot count (1-100)");
        resp.Messages.Add("  SET/SKIMMER                      - Enable CW skimmer spots from peer nodes");
        resp.Messages.Add("  SET/NOSKIMMER                    - Suppress CW skimmer spots");
        resp.Messages.Add("  SET/RBN                          - Enable Reverse Beacon Network spots");
        resp.Messages.Add("  SET/NORBN                        - Suppress RBN spots");
        resp.Messages.Add("  TEST DX <freq> <call> [comment]  - Preview a spot locally (not propagated)");
        resp.Messages.Add("  SH/STA [callsign]                - Show station info");
        resp.Messages.Add("  T <callsign> <message>           - Send a private talk message");
        resp.Messages.Add("  ANN <message>                    - Announce to all connected users");
        resp.Messages.Add("  WWV <sfi> <a> <k> [forecast]     - Post a WWV propagation report");
        resp.Messages.Add("  SH/WWV [n]                       - Show last n WWV reports (default 5)");
        resp.Messages.Add("  WX <message>                     - Post a weather announcement");
        resp.Messages.Add("  SH/WX [n]                        - Show last n WX reports (default 5)");
        resp.Messages.Add("  ADD/BUDDY <callsign>             - Add callsign to your buddy list");
        resp.Messages.Add("  DEL/BUDDY <callsign>             - Remove callsign from your buddy list");
        resp.Messages.Add("  SH/BUDDY                         - Show your buddy list and online status");
        resp.Messages.Add("  BYE                              - Disconnect");
        resp.Messages.Add("  HELP                             - This help");
        resp.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}
