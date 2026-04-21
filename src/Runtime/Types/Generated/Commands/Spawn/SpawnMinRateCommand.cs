using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Minimum spawn rate scalar applied to NPC/resource population spawning; lower values slow down respawn ticking when server population is low</summary>
/// <remarks>Full RCON name: <c>spawn.min_rate</c></remarks>
public sealed class SpawnMinRateCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.min_rate";

    /// <summary>Reads the current value of <c>spawn.min_rate</c>.</summary>
    public static SpawnMinRateCommand CreateGet()
    {
        var cmd = CreatePackage<SpawnMinRateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>spawn.min_rate</c> to <paramref name="value"/>.</summary>
    public static SpawnMinRateCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SpawnMinRateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
