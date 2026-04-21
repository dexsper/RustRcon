using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Bags will increase their respawn time by this much</summary>
/// <remarks>Full RCON name: <c>server.respawntimeadditionbag</c></remarks>
public sealed class ServerRespawntimeadditionbagCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.respawntimeadditionbag";

    /// <summary>Reads the current value of <c>server.respawntimeadditionbag</c>.</summary>
    public static ServerRespawntimeadditionbagCommand CreateGet()
    {
        var cmd = CreatePackage<ServerRespawntimeadditionbagCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.respawntimeadditionbag</c> to <paramref name="value"/>.</summary>
    public static ServerRespawntimeadditionbagCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerRespawntimeadditionbagCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
