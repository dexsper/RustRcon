using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Minimum population density scalar; controls the lower bound for how densely spawnable items fill their designated spawn areas at low player counts</summary>
/// <remarks>Full RCON name: <c>spawn.min_density</c></remarks>
public sealed class SpawnMinDensityCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.min_density";

    /// <summary>Reads the current value of <c>spawn.min_density</c>.</summary>
    public static SpawnMinDensityCommand CreateGet()
    {
        var cmd = CreatePackage<SpawnMinDensityCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>spawn.min_density</c> to <paramref name="value"/>.</summary>
    public static SpawnMinDensityCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SpawnMinDensityCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
