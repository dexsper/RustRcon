using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If set the loot spawn system will consider this the player count, not the actual player count. Useful for testing</summary>
/// <remarks>Full RCON name: <c>spawn.loot_population_test</c></remarks>
public sealed class SpawnLootPopulationTestCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.loot_population_test";

    /// <summary>Reads the current value of <c>spawn.loot_population_test</c>.</summary>
    public static SpawnLootPopulationTestCommand CreateGet()
    {
        var cmd = CreatePackage<SpawnLootPopulationTestCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>spawn.loot_population_test</c> to <paramref name="value"/>.</summary>
    public static SpawnLootPopulationTestCommand CreateSet(int value)
    {
        var cmd = CreatePackage<SpawnLootPopulationTestCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
