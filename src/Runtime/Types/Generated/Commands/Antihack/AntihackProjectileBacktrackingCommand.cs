using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_backtracking</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_backtracking</c></remarks>
public sealed class AntihackProjectileBacktrackingCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_backtracking";

    /// <summary>Reads the current value of <c>antihack.projectile_backtracking</c>.</summary>
    public static AntihackProjectileBacktrackingCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileBacktrackingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_backtracking</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileBacktrackingCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackProjectileBacktrackingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
