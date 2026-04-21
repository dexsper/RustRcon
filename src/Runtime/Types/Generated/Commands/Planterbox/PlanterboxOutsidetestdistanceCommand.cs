using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum distance in metres used when raycasting to determine whether a planter box is outdoors and receiving natural sunlight</summary>
/// <remarks>Full RCON name: <c>planterbox.outsidetestdistance</c></remarks>
public sealed class PlanterboxOutsidetestdistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "planterbox.outsidetestdistance";

    /// <summary>Reads the current value of <c>planterbox.outsidetestdistance</c>.</summary>
    public static PlanterboxOutsidetestdistanceCommand CreateGet()
    {
        var cmd = CreatePackage<PlanterboxOutsidetestdistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>planterbox.outsidetestdistance</c> to <paramref name="value"/>.</summary>
    public static PlanterboxOutsidetestdistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PlanterboxOutsidetestdistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
