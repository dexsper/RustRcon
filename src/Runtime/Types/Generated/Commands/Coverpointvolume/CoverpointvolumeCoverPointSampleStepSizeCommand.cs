using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>cover_point_sample_step_size defines the size of the steps we do horizontally for the cover point volume's cover point generation (smaller steps gives more accurate cover points, but at a higher processing cost). (default: 6.0)</summary>
/// <remarks>Full RCON name: <c>coverpointvolume.cover_point_sample_step_size</c></remarks>
public sealed class CoverpointvolumeCoverPointSampleStepSizeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "coverpointvolume.cover_point_sample_step_size";

    /// <summary>Reads the current value of <c>coverpointvolume.cover_point_sample_step_size</c>.</summary>
    public static CoverpointvolumeCoverPointSampleStepSizeCommand CreateGet()
    {
        var cmd = CreatePackage<CoverpointvolumeCoverPointSampleStepSizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>coverpointvolume.cover_point_sample_step_size</c> to <paramref name="value"/>.</summary>
    public static CoverpointvolumeCoverPointSampleStepSizeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<CoverpointvolumeCoverPointSampleStepSizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
