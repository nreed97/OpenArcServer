using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Core.Services;

/// <summary>
/// Processes a decoded ARx2 XML message on behalf of a session.
/// Implemented in OpenArcServer.Protocols.Arx and injected into
/// TelnetClientConnection so the telnet handler can process ARx2
/// frames that arrive after the plain-text login handshake.
/// </summary>
public interface IArxMessageProcessor
{
    Task ProcessAsync(UserSession session, string xml, CancellationToken ct);
}
