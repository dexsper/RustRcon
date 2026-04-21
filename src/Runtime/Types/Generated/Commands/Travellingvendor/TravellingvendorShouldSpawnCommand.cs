using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, the Travelling Vendor NPC is eligible to spawn on the server ring road; disable to prevent vendor spawning</summary>
/// <remarks>Full RCON name: <c>travellingvendor.should_spawn</c></remarks>
public sealed class TravellingvendorShouldSpawnCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "travellingvendor.should_spawn";

    /// <summary>Reads the current value of <c>travellingvendor.should_spawn</c>.</summary>
    public static TravellingvendorShouldSpawnCommand CreateGet()
    {
        var cmd = CreatePackage<TravellingvendorShouldSpawnCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>travellingvendor.should_spawn</c> to <paramref name="value"/>.</summary>
    public static TravellingvendorShouldSpawnCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<TravellingvendorShouldSpawnCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
