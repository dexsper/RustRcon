using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Beds will increase their respawn time by this much</summary>
/// <remarks>Full RCON name: <c>server.respawntimeadditionbed</c></remarks>
public sealed class ServerRespawntimeadditionbedCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.respawntimeadditionbed";

    /// <summary>Reads the current value of <c>server.respawntimeadditionbed</c>.</summary>
    public static ServerRespawntimeadditionbedCommand CreateGet()
    {
        var cmd = CreatePackage<ServerRespawntimeadditionbedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.respawntimeadditionbed</c> to <paramref name="value"/>.</summary>
    public static ServerRespawntimeadditionbedCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerRespawntimeadditionbedCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
