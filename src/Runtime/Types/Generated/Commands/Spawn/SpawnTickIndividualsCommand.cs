using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in seconds between individual entity respawn ticks; controls how frequently the server checks for and respawns dead individual entities</summary>
/// <remarks>Full RCON name: <c>spawn.tick_individuals</c></remarks>
public sealed class SpawnTickIndividualsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.tick_individuals";

    /// <summary>Reads the current value of <c>spawn.tick_individuals</c>.</summary>
    public static SpawnTickIndividualsCommand CreateGet()
    {
        var cmd = CreatePackage<SpawnTickIndividualsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>spawn.tick_individuals</c> to <paramref name="value"/>.</summary>
    public static SpawnTickIndividualsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SpawnTickIndividualsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
