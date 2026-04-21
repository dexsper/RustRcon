using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, logs when entities die because their ground support entity was destroyed or is missing</summary>
/// <remarks>Full RCON name: <c>stability.log_ground_missing_death</c></remarks>
public sealed class StabilityLogGroundMissingDeathCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "stability.log_ground_missing_death";

    /// <summary>Reads the current value of <c>stability.log_ground_missing_death</c>.</summary>
    public static StabilityLogGroundMissingDeathCommand CreateGet()
    {
        var cmd = CreatePackage<StabilityLogGroundMissingDeathCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>stability.log_ground_missing_death</c> to <paramref name="value"/>.</summary>
    public static StabilityLogGroundMissingDeathCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<StabilityLogGroundMissingDeathCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
