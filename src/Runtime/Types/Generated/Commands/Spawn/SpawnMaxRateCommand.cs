using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum spawn rate scalar applied to NPC/resource population spawning; the spawn tick rate scales up to this value as player count increases</summary>
/// <remarks>Full RCON name: <c>spawn.max_rate</c></remarks>
public sealed class SpawnMaxRateCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.max_rate";

    /// <summary>Reads the current value of <c>spawn.max_rate</c>.</summary>
    public static SpawnMaxRateCommand CreateGet()
    {
        var cmd = CreatePackage<SpawnMaxRateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>spawn.max_rate</c> to <paramref name="value"/>.</summary>
    public static SpawnMaxRateCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SpawnMaxRateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
