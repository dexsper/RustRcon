using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, logs every stability value change during propagation; very verbose, use only for targeted debugging</summary>
/// <remarks>Full RCON name: <c>stability.log_stability_updates</c></remarks>
public sealed class StabilityLogStabilityUpdatesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "stability.log_stability_updates";

    /// <summary>Reads the current value of <c>stability.log_stability_updates</c>.</summary>
    public static StabilityLogStabilityUpdatesCommand CreateGet()
    {
        var cmd = CreatePackage<StabilityLogStabilityUpdatesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>stability.log_stability_updates</c> to <paramref name="value"/>.</summary>
    public static StabilityLogStabilityUpdatesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<StabilityLogStabilityUpdatesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
