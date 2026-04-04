using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Engine.Commands;

// ---------------------------------------------------------------------------
// ADD/BUDDY <callsign>  — add a callsign to your buddy list
// ---------------------------------------------------------------------------
public sealed class AddBuddyCommand : IArcCommand
{
    private readonly IBuddyRepository _buddies;

    public AddBuddyCommand(IBuddyRepository buddies) => _buddies = buddies;

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var resp = context.Response;
        var tokens = context.Request.Tokens;

        // Tokens: [ADD, BUDDY, <callsign>]
        int buddyIdx = Array.FindIndex(tokens, t => t.Equals("BUDDY", StringComparison.OrdinalIgnoreCase));
        if (buddyIdx < 0 || buddyIdx + 1 >= tokens.Length)
        {
            resp.Messages.Add("Usage: ADD/BUDDY <callsign>  (e.g. ADD/BUDDY W1AW)");
            resp.DistroType = DistroType.ToRequester;
            return;
        }

        var buddy = tokens[buddyIdx + 1].ToUpperInvariant();
        if (buddy.Equals(context.Session.Callsign, StringComparison.OrdinalIgnoreCase))
        {
            resp.Messages.Add("You cannot add yourself to your buddy list.");
            resp.DistroType = DistroType.ToRequester;
            return;
        }

        await _buddies.AddAsync(context.Session.Callsign, buddy, ct);
        resp.Messages.Add($"{buddy} added to your buddy list.");
        resp.DistroType = DistroType.ToRequester;
    }
}

// ---------------------------------------------------------------------------
// DEL/BUDDY <callsign>  — remove a callsign from your buddy list
// ---------------------------------------------------------------------------
public sealed class DelBuddyCommand : IArcCommand
{
    private readonly IBuddyRepository _buddies;

    public DelBuddyCommand(IBuddyRepository buddies) => _buddies = buddies;

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var resp = context.Response;
        var tokens = context.Request.Tokens;

        int buddyIdx = Array.FindIndex(tokens, t => t.Equals("BUDDY", StringComparison.OrdinalIgnoreCase));
        if (buddyIdx < 0 || buddyIdx + 1 >= tokens.Length)
        {
            resp.Messages.Add("Usage: DEL/BUDDY <callsign>  (e.g. DEL/BUDDY W1AW)");
            resp.DistroType = DistroType.ToRequester;
            return;
        }

        var buddy = tokens[buddyIdx + 1].ToUpperInvariant();
        await _buddies.RemoveAsync(context.Session.Callsign, buddy, ct);
        resp.Messages.Add($"{buddy} removed from your buddy list.");
        resp.DistroType = DistroType.ToRequester;
    }
}

// ---------------------------------------------------------------------------
// SH/BUDDY  — list your buddy list and who is currently online
// ---------------------------------------------------------------------------
public sealed class ShowBuddyCommand : IArcCommand
{
    private readonly IBuddyRepository _buddies;
    private readonly IConnectionManager _connections;

    public ShowBuddyCommand(IBuddyRepository buddies, IConnectionManager connections)
    {
        _buddies = buddies;
        _connections = connections;
    }

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var resp = context.Response;
        var list = await _buddies.GetBuddiesAsync(context.Session.Callsign, ct);

        if (list.Count == 0)
        {
            resp.Messages.Add("Your buddy list is empty. Use ADD/BUDDY <callsign> to add buddies.");
        }
        else
        {
            resp.Messages.Add($"Your buddy list ({list.Count} entries):");
            foreach (var buddy in list)
            {
                var session = _connections.FindByCallsign(buddy);
                var status = session is not null ? "ONLINE" : "offline";
                resp.Messages.Add($"  {buddy,-12}  {status}");
            }
        }

        resp.DistroType = DistroType.ToRequester;
    }
}
