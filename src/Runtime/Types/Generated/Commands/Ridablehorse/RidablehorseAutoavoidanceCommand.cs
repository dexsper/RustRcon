using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, horses use automatic avoidance steering to navigate around obstacles; saved between sessions; admin configurable</summary>
/// <remarks>Full RCON name: <c>ridablehorse.autoavoidance</c></remarks>
public sealed class RidablehorseAutoavoidanceCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ridablehorse.autoavoidance";

    /// <summary>Reads the current value of <c>ridablehorse.autoavoidance</c>.</summary>
    public static RidablehorseAutoavoidanceCommand CreateGet()
    {
        var cmd = CreatePackage<RidablehorseAutoavoidanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ridablehorse.autoavoidance</c> to <paramref name="value"/>.</summary>
    public static RidablehorseAutoavoidanceCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<RidablehorseAutoavoidanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
