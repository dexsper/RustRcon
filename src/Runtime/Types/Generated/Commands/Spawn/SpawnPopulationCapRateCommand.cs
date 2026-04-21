using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>When scaling loot respawn rates by population, this will be considered the 'max' population, preventing loot speeding up if player counts are above this</summary>
/// <remarks>Full RCON name: <c>spawn.population_cap_rate</c></remarks>
public sealed class SpawnPopulationCapRateCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.population_cap_rate";

    /// <summary>Reads the current value of <c>spawn.population_cap_rate</c>.</summary>
    public static SpawnPopulationCapRateCommand CreateGet()
    {
        var cmd = CreatePackage<SpawnPopulationCapRateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>spawn.population_cap_rate</c> to <paramref name="value"/>.</summary>
    public static SpawnPopulationCapRateCommand CreateSet(int value)
    {
        var cmd = CreatePackage<SpawnPopulationCapRateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
