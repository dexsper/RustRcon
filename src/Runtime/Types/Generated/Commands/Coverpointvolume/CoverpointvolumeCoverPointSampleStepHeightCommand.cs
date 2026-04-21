using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>cover_point_sample_step_height defines the height of the steps we do vertically for the cover point volume's cover point generation (smaller steps gives more accurate cover points, but at a higher processing cost). (default: 2.0)</summary>
/// <remarks>Full RCON name: <c>coverpointvolume.cover_point_sample_step_height</c></remarks>
public sealed class CoverpointvolumeCoverPointSampleStepHeightCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "coverpointvolume.cover_point_sample_step_height";

    /// <summary>Reads the current value of <c>coverpointvolume.cover_point_sample_step_height</c>.</summary>
    public static CoverpointvolumeCoverPointSampleStepHeightCommand CreateGet()
    {
        var cmd = CreatePackage<CoverpointvolumeCoverPointSampleStepHeightCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>coverpointvolume.cover_point_sample_step_height</c> to <paramref name="value"/>.</summary>
    public static CoverpointvolumeCoverPointSampleStepHeightCommand CreateSet(float value)
    {
        var cmd = CreatePackage<CoverpointvolumeCoverPointSampleStepHeightCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
