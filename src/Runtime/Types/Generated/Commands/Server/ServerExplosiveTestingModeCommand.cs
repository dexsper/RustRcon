using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Lower damage of explosives to 1 and allow them to be triggered multiple times</summary>
/// <remarks>Full RCON name: <c>server.explosive_testing_mode</c></remarks>
public sealed class ServerExplosiveTestingModeCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.explosive_testing_mode";

    /// <summary>Reads the current value of <c>server.explosive_testing_mode</c>.</summary>
    public static ServerExplosiveTestingModeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerExplosiveTestingModeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.explosive_testing_mode</c> to <paramref name="value"/>.</summary>
    public static ServerExplosiveTestingModeCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerExplosiveTestingModeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
