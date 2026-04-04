using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Core.Services;

public interface IMessageDistributor
{
    Task DistributeAsync(CommandResponse response, UserSession sender, CancellationToken ct = default);
}
