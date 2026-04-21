using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, logs each entity death caused by a stability collapse to the server console with position and prefab name</summary>
/// <remarks>Full RCON name: <c>stability.log_stability_death</c></remarks>
public sealed class StabilityLogStabilityDeathCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "stability.log_stability_death";

    /// <summary>Reads the current value of <c>stability.log_stability_death</c>.</summary>
    public static StabilityLogStabilityDeathCommand CreateGet()
    {
        var cmd = CreatePackage<StabilityLogStabilityDeathCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>stability.log_stability_death</c> to <paramref name="value"/>.</summary>
    public static StabilityLogStabilityDeathCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<StabilityLogStabilityDeathCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
