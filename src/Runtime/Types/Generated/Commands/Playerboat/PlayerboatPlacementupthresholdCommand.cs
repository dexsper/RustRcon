using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum angle in degrees from vertical at which building blocks can be placed on a player boat; default 30 degrees</summary>
/// <remarks>Full RCON name: <c>playerboat.placementupthreshold</c></remarks>
public sealed class PlayerboatPlacementupthresholdCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.placementupthreshold";

    /// <summary>Reads the current value of <c>playerboat.placementupthreshold</c>.</summary>
    public static PlayerboatPlacementupthresholdCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatPlacementupthresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.placementupthreshold</c> to <paramref name="value"/>.</summary>
    public static PlayerboatPlacementupthresholdCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PlayerboatPlacementupthresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
