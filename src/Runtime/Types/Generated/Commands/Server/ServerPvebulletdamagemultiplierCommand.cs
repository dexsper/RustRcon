using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Additional bullet damage multiplier applied only when players shoot NPCs or animals, stacks with bulletdamage</summary>
/// <remarks>Full RCON name: <c>server.pvebulletdamagemultiplier</c></remarks>
public sealed class ServerPvebulletdamagemultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.pvebulletdamagemultiplier";

    /// <summary>Reads the current value of <c>server.pvebulletdamagemultiplier</c>.</summary>
    public static ServerPvebulletdamagemultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPvebulletdamagemultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.pvebulletdamagemultiplier</c> to <paramref name="value"/>.</summary>
    public static ServerPvebulletdamagemultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerPvebulletdamagemultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
