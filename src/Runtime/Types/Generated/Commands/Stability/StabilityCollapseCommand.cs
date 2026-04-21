using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Stability value below which a building block is considered unsupported and will collapse; default 0.05 means blocks below 5% support fall</summary>
/// <remarks>Full RCON name: <c>stability.collapse</c></remarks>
public sealed class StabilityCollapseCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "stability.collapse";

    /// <summary>Reads the current value of <c>stability.collapse</c>.</summary>
    public static StabilityCollapseCommand CreateGet()
    {
        var cmd = CreatePackage<StabilityCollapseCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>stability.collapse</c> to <paramref name="value"/>.</summary>
    public static StabilityCollapseCommand CreateSet(float value)
    {
        var cmd = CreatePackage<StabilityCollapseCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
