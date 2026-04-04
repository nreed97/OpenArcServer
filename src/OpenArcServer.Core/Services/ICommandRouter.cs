using OpenArcServer.Core.Commands;

namespace OpenArcServer.Core.Services;

public interface ICommandRouter
{
    /// <summary>Find a command by normalized key (e.g. "SH DX", "DX", "BYE")</summary>
    IArcCommand? Resolve(string commandKey);

    /// <summary>Register a command under all its abbreviation expansions</summary>
    void Register(string definition, IArcCommand command);
}
