using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_penalty</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_penalty</c></remarks>
public sealed class AntihackProjectilePenaltyCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_penalty";

    /// <summary>Reads the current value of <c>antihack.projectile_penalty</c>.</summary>
    public static AntihackProjectilePenaltyCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectilePenaltyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_penalty</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectilePenaltyCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackProjectilePenaltyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
