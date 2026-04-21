using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables radiation zones at monuments; disabling removes all radiation hazards from the map</summary>
/// <remarks>Full RCON name: <c>server.radiation</c></remarks>
public sealed class ServerRadiationCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.radiation";

    /// <summary>Reads the current value of <c>server.radiation</c>.</summary>
    public static ServerRadiationCommand CreateGet()
    {
        var cmd = CreatePackage<ServerRadiationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.radiation</c> to <paramref name="value"/>.</summary>
    public static ServerRadiationCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerRadiationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
