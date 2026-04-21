using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When true, players can grab and swing on deployed vines; disable to prevent vine-swinging movement</summary>
/// <remarks>Full RCON name: <c>server.allowvineswinging</c></remarks>
public sealed class ServerAllowvineswingingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.allowvineswinging";

    /// <summary>Reads the current value of <c>server.allowvineswinging</c>.</summary>
    public static ServerAllowvineswingingCommand CreateGet()
    {
        var cmd = CreatePackage<ServerAllowvineswingingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.allowvineswinging</c> to <paramref name="value"/>.</summary>
    public static ServerAllowvineswingingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerAllowvineswingingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
