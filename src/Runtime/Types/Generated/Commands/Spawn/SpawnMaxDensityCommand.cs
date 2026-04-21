using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum population density scalar; controls the upper bound for how densely spawnable items fill their designated spawn areas at high player counts</summary>
/// <remarks>Full RCON name: <c>spawn.max_density</c></remarks>
public sealed class SpawnMaxDensityCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.max_density";

    /// <summary>Reads the current value of <c>spawn.max_density</c>.</summary>
    public static SpawnMaxDensityCommand CreateGet()
    {
        var cmd = CreatePackage<SpawnMaxDensityCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>spawn.max_density</c> to <paramref name="value"/>.</summary>
    public static SpawnMaxDensityCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SpawnMaxDensityCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
