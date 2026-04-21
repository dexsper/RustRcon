using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in seconds between population spawn ticks; lower values cause populations to refill faster but increase server CPU load</summary>
/// <remarks>Full RCON name: <c>spawn.tick_populations</c></remarks>
public sealed class SpawnTickPopulationsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.tick_populations";

    /// <summary>Reads the current value of <c>spawn.tick_populations</c>.</summary>
    public static SpawnTickPopulationsCommand CreateGet()
    {
        var cmd = CreatePackage<SpawnTickPopulationsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>spawn.tick_populations</c> to <paramref name="value"/>.</summary>
    public static SpawnTickPopulationsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SpawnTickPopulationsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
