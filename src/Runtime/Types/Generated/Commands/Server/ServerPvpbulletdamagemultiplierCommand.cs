using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Additional bullet damage multiplier applied only in player-vs-player combat, stacks with bulletdamage</summary>
/// <remarks>Full RCON name: <c>server.pvpbulletdamagemultiplier</c></remarks>
public sealed class ServerPvpbulletdamagemultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.pvpbulletdamagemultiplier";

    /// <summary>Reads the current value of <c>server.pvpbulletdamagemultiplier</c>.</summary>
    public static ServerPvpbulletdamagemultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPvpbulletdamagemultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.pvpbulletdamagemultiplier</c> to <paramref name="value"/>.</summary>
    public static ServerPvpbulletdamagemultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerPvpbulletdamagemultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
