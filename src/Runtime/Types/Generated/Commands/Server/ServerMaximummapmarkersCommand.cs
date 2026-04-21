using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many markers each player can place</summary>
/// <remarks>Full RCON name: <c>server.maximummapmarkers</c></remarks>
public sealed class ServerMaximummapmarkersCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maximummapmarkers";

    /// <summary>Reads the current value of <c>server.maximummapmarkers</c>.</summary>
    public static ServerMaximummapmarkersCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaximummapmarkersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maximummapmarkers</c> to <paramref name="value"/>.</summary>
    public static ServerMaximummapmarkersCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaximummapmarkersCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
