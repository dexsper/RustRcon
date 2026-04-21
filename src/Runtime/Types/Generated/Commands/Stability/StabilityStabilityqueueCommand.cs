using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum time in seconds that stability update jobs can run per server tick before being deferred to the next tick</summary>
/// <remarks>Full RCON name: <c>stability.stabilityqueue</c></remarks>
public sealed class StabilityStabilityqueueCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "stability.stabilityqueue";

    /// <summary>Reads the current value of <c>stability.stabilityqueue</c>.</summary>
    public static StabilityStabilityqueueCommand CreateGet()
    {
        var cmd = CreatePackage<StabilityStabilityqueueCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>stability.stabilityqueue</c> to <paramref name="value"/>.</summary>
    public static StabilityStabilityqueueCommand CreateSet(float value)
    {
        var cmd = CreatePackage<StabilityStabilityqueueCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
