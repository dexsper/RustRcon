using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Stopping distance for destinations set while chasing a target (Default: 0.5)</summary>
/// <remarks>Full RCON name: <c>halloween.scarecrow_chase_stopping_distance</c></remarks>
public sealed class HalloweenScarecrowChaseStoppingDistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "halloween.scarecrow_chase_stopping_distance";

    /// <summary>Reads the current value of <c>halloween.scarecrow_chase_stopping_distance</c>.</summary>
    public static HalloweenScarecrowChaseStoppingDistanceCommand CreateGet()
    {
        var cmd = CreatePackage<HalloweenScarecrowChaseStoppingDistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>halloween.scarecrow_chase_stopping_distance</c> to <paramref name="value"/>.</summary>
    public static HalloweenScarecrowChaseStoppingDistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HalloweenScarecrowChaseStoppingDistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
