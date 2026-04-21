using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Fraction of available upload bandwidth used when uploading demo files (0-1); lower values prevent demos from saturating the server connection</summary>
/// <remarks>Full RCON name: <c>demo.upload_bandwidth_limit_ratio</c></remarks>
public sealed class DemoUploadBandwidthLimitRatioCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.upload_bandwidth_limit_ratio";

    /// <summary>Reads the current value of <c>demo.upload_bandwidth_limit_ratio</c>.</summary>
    public static DemoUploadBandwidthLimitRatioCommand CreateGet()
    {
        var cmd = CreatePackage<DemoUploadBandwidthLimitRatioCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>demo.upload_bandwidth_limit_ratio</c> to <paramref name="value"/>.</summary>
    public static DemoUploadBandwidthLimitRatioCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DemoUploadBandwidthLimitRatioCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
