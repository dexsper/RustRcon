using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Controls whether the tutorial is enabled on this server</summary>
/// <remarks>Full RCON name: <c>server.tutorialenabled</c></remarks>
public sealed class ServerTutorialenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.tutorialenabled";

    /// <summary>Reads the current value of <c>server.tutorialenabled</c>.</summary>
    public static ServerTutorialenabledCommand CreateGet()
    {
        var cmd = CreatePackage<ServerTutorialenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.tutorialenabled</c> to <paramref name="value"/>.</summary>
    public static ServerTutorialenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerTutorialenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
