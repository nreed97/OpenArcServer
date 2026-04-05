using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Engine.Commands;

// ---------------------------------------------------------------------------
// Shared helpers
// ---------------------------------------------------------------------------
file static class SetProfileHelpers
{
    /// <summary>Returns the tail of the raw message after the given verb prefix.</summary>
    public static string TailAfterVerb(string raw, string verb)
    {
        var idx = raw.IndexOf(verb, StringComparison.OrdinalIgnoreCase);
        if (idx < 0) return string.Empty;
        var after = raw[(idx + verb.Length)..].TrimStart();
        return after;
    }

    public static async Task<UserProfile> LoadAndApply(
        UserSession session,
        IUserRepository repo,
        Action<UserProfile> apply,
        CancellationToken ct)
    {
        var profile = await repo.GetOrCreateAsync(session.Callsign, ct);
        apply(profile);
        await repo.UpdateAsync(profile, ct);
        return profile;
    }
}

// ---------------------------------------------------------------------------
// SET/NAME <name>
// ---------------------------------------------------------------------------
public sealed class SetNameCommand : IArcCommand
{
    private readonly IUserRepository _users;
    public SetNameCommand(IUserRepository users) => _users = users;

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var value = SetProfileHelpers.TailAfterVerb(context.Request.RawMessage, "NAME");
        if (string.IsNullOrWhiteSpace(value))
        {
            context.Response.Messages.Add("Usage: SET/NAME <your name>  (e.g. SET/NAME John Smith)");
            context.Response.DistroType = DistroType.ToRequester;
            return;
        }
        context.Session.Name = value;
        await SetProfileHelpers.LoadAndApply(context.Session, _users,
            p => p.Name = value, ct);
        context.Response.Messages.Add($"Name set to: {value}");
        context.Response.DistroType = DistroType.ToRequester;
    }
}

// ---------------------------------------------------------------------------
// SET/QTH <location>
// ---------------------------------------------------------------------------
public sealed class SetQthCommand : IArcCommand
{
    private readonly IUserRepository _users;
    public SetQthCommand(IUserRepository users) => _users = users;

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var value = SetProfileHelpers.TailAfterVerb(context.Request.RawMessage, "QTH");
        if (string.IsNullOrWhiteSpace(value))
        {
            context.Response.Messages.Add("Usage: SET/QTH <location>  (e.g. SET/QTH Boston, MA)");
            context.Response.DistroType = DistroType.ToRequester;
            return;
        }
        context.Session.Qth = value;
        await SetProfileHelpers.LoadAndApply(context.Session, _users,
            p => p.Qth = value, ct);
        context.Response.Messages.Add($"QTH set to: {value}");
        context.Response.DistroType = DistroType.ToRequester;
    }
}

// ---------------------------------------------------------------------------
// SET/GRID <grid>
// ---------------------------------------------------------------------------
public sealed class SetGridCommand : IArcCommand
{
    private readonly IUserRepository _users;
    public SetGridCommand(IUserRepository users) => _users = users;

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var value = SetProfileHelpers.TailAfterVerb(context.Request.RawMessage, "GRID")
                                     .ToUpperInvariant();
        if (string.IsNullOrWhiteSpace(value))
        {
            context.Response.Messages.Add("Usage: SET/GRID <grid>  (e.g. SET/GRID FN42)");
            context.Response.DistroType = DistroType.ToRequester;
            return;
        }
        context.Session.Grid = value;
        await SetProfileHelpers.LoadAndApply(context.Session, _users,
            p => p.Grid = value, ct);
        context.Response.Messages.Add($"Grid set to: {value}");
        context.Response.DistroType = DistroType.ToRequester;
    }
}

// ---------------------------------------------------------------------------
// SET/EMAIL <address>
// ---------------------------------------------------------------------------
public sealed class SetEmailCommand : IArcCommand
{
    private readonly IUserRepository _users;
    public SetEmailCommand(IUserRepository users) => _users = users;

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var value = SetProfileHelpers.TailAfterVerb(context.Request.RawMessage, "EMAIL");
        if (string.IsNullOrWhiteSpace(value))
        {
            context.Response.Messages.Add("Usage: SET/EMAIL <address>  (e.g. SET/EMAIL w1aw@arrl.org)");
            context.Response.DistroType = DistroType.ToRequester;
            return;
        }
        context.Session.Email = value;
        await SetProfileHelpers.LoadAndApply(context.Session, _users,
            p => p.Email = value, ct);
        context.Response.Messages.Add($"Email set to: {value}");
        context.Response.DistroType = DistroType.ToRequester;
    }
}

// ---------------------------------------------------------------------------
// SET/DXCOUNT <n>  — default number of spots shown by SH/DX
// ---------------------------------------------------------------------------
public sealed class SetDxCountCommand : IArcCommand
{
    private readonly IUserRepository _users;
    public SetDxCountCommand(IUserRepository users) => _users = users;

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var tokens = context.Request.Tokens;
        // Last token should be the number
        if (tokens.Length == 0 || !int.TryParse(tokens[^1], out var n) || n < 1 || n > 100)
        {
            context.Response.Messages.Add("Usage: SET/DXCOUNT <n>  (1-100, e.g. SET/DXCOUNT 20)");
            context.Response.DistroType = DistroType.ToRequester;
            return;
        }
        context.Session.DxCount = n;
        await SetProfileHelpers.LoadAndApply(context.Session, _users,
            p => p.DxCount = n, ct);
        context.Response.Messages.Add($"DX spot count set to: {n}");
        context.Response.DistroType = DistroType.ToRequester;
    }
}

// ---------------------------------------------------------------------------
// SH/STA [callsign]  — show station info for yourself or another user
// ---------------------------------------------------------------------------
public sealed class ShowStationCommand : IArcCommand
{
    private readonly IUserRepository _users;
    private readonly IConnectionManager _connections;

    public ShowStationCommand(IUserRepository users, IConnectionManager connections)
    {
        _users = users;
        _connections = connections;
    }

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var tokens = context.Request.Tokens;
        var resp = context.Response;

        // SH/STA [callsign]
        string callsign = context.Session.Callsign;
        int staIdx = Array.FindIndex(tokens, t => t.Equals("STA", StringComparison.OrdinalIgnoreCase)
                                               || t.Equals("STATION", StringComparison.OrdinalIgnoreCase));
        if (staIdx >= 0 && staIdx + 1 < tokens.Length)
            callsign = tokens[staIdx + 1].ToUpperInvariant();

        // Check live session first for up-to-date data
        var live = _connections.FindByCallsign(callsign);
        if (live is not null && callsign.Equals(context.Session.Callsign, StringComparison.OrdinalIgnoreCase))
        {
            // Own session — show in-memory state
            PrintSession(resp, live);
        }
        else if (live is not null)
        {
            PrintSession(resp, live);
        }
        else
        {
            // Load from DB
            var profile = await _users.GetOrCreateAsync(callsign, ct);
            resp.Messages.Add($"Callsign : {profile.Callsign}");
            resp.Messages.Add($"Name     : {(string.IsNullOrEmpty(profile.Name) ? "(not set)" : profile.Name)}");
            resp.Messages.Add($"QTH      : {(string.IsNullOrEmpty(profile.Qth) ? "(not set)" : profile.Qth)}");
            resp.Messages.Add($"Grid     : {(string.IsNullOrEmpty(profile.Grid) ? "(not set)" : profile.Grid)}");
            resp.Messages.Add($"Email    : {(string.IsNullOrEmpty(profile.Email) ? "(not set)" : profile.Email)}");
            resp.Messages.Add($"Connects : {profile.TotalConnects}");
            resp.Messages.Add($"Last on  : {profile.LastSeen:dd-MMM-yyyy HH:mmZ}");
            resp.Messages.Add("(User is not currently connected)");
        }

        resp.DistroType = DistroType.ToRequester;
    }

    private static void PrintSession(CommandResponse resp, UserSession s)
    {
        resp.Messages.Add($"Callsign : {s.Callsign}");
        resp.Messages.Add($"Name     : {(string.IsNullOrEmpty(s.Name) ? "(not set)" : s.Name)}");
        resp.Messages.Add($"QTH      : {(string.IsNullOrEmpty(s.Qth) ? "(not set)" : s.Qth)}");
        resp.Messages.Add($"Grid     : {(string.IsNullOrEmpty(s.Grid) ? "(not set)" : s.Grid)}");
        resp.Messages.Add($"Email    : {(string.IsNullOrEmpty(s.Email) ? "(not set)" : s.Email)}");
        resp.Messages.Add($"DX count : {s.DxCount}");
        resp.Messages.Add($"Skimmer  : {(s.ReceiveSkimmer ? "ON" : "OFF")}");
        resp.Messages.Add($"Filter   : {s.SpotFilter.Describe()}");
        resp.Messages.Add($"Online   : {(DateTime.UtcNow - s.ConnectedAt).ToString(@"hh\:mm")} h");
    }
}

// ---------------------------------------------------------------------------
// SET/SKIMMER  — enable receiving skimmer/RBN spots
// ---------------------------------------------------------------------------
public sealed class SetSkimmerCommand : IArcCommand
{
    private readonly IConnectionManager _connections;
    private readonly IArxClientRegistry _arxClients;

    public SetSkimmerCommand(IConnectionManager connections, IArxClientRegistry arxClients)
    {
        _connections = connections;
        _arxClients  = arxClients;
    }

    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        ApplyToAllSessions(context.Session.Callsign, true, _connections, _arxClients);
        context.Response.Messages.Add("Skimmer/RBN spots enabled.");
        context.Response.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }

    internal static void ApplyToAllSessions(
        string callsign, bool value,
        IConnectionManager connections, IArxClientRegistry arxClients)
    {
        // Update every session for this callsign regardless of protocol
        foreach (var s in connections.GetConnectedUsers()
                     .Where(s => s.Callsign.Equals(callsign, StringComparison.OrdinalIgnoreCase)))
            s.ReceiveSkimmer = value;

        foreach (var s in arxClients.GetAll()
                     .Where(s => s.Callsign.Equals(callsign, StringComparison.OrdinalIgnoreCase)))
            s.ReceiveSkimmer = value;
    }
}

// ---------------------------------------------------------------------------
// SET/NOSKIMMER  — suppress skimmer/RBN spots
// ---------------------------------------------------------------------------
public sealed class SetNoSkimmerCommand : IArcCommand
{
    private readonly IConnectionManager _connections;
    private readonly IArxClientRegistry _arxClients;

    public SetNoSkimmerCommand(IConnectionManager connections, IArxClientRegistry arxClients)
    {
        _connections = connections;
        _arxClients  = arxClients;
    }

    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        SetSkimmerCommand.ApplyToAllSessions(context.Session.Callsign, false, _connections, _arxClients);
        context.Response.Messages.Add("Skimmer/RBN spots disabled. Use SET/SKIMMER to re-enable.");
        context.Response.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}
