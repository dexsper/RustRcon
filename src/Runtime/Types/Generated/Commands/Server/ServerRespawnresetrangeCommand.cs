using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Radius in metres around a player's death point — any sleeping bag or bed within this range is put on a respawn cooldown to prevent spawn-camping</summary>
/// <remarks>Full RCON name: <c>server.respawnresetrange</c></remarks>
public sealed class ServerRespawnresetrangeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.respawnresetrange";

    /// <summary>Reads the current value of <c>server.respawnresetrange</c>.</summary>
    public static ServerRespawnresetrangeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerRespawnresetrangeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.respawnresetrange</c> to <paramref name="value"/>.</summary>
    public static ServerRespawnresetrangeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerRespawnresetrangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
