using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Global multiplier for all melee weapon damage dealt; 1.0 = default, 2.0 = double damage, 0.5 = half damage</summary>
/// <remarks>Full RCON name: <c>server.meleedamage</c></remarks>
public sealed class ServerMeleedamageCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.meleedamage";

    /// <summary>Reads the current value of <c>server.meleedamage</c>.</summary>
    public static ServerMeleedamageCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMeleedamageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.meleedamage</c> to <paramref name="value"/>.</summary>
    public static ServerMeleedamageCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerMeleedamageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
