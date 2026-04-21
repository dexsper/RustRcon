using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cctv.camera_disable_seconds</c>.</summary>
/// <remarks>Full RCON name: <c>cctv.camera_disable_seconds</c></remarks>
public sealed class CctvCameraDisableSecondsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cctv.camera_disable_seconds";

    /// <summary>Reads the current value of <c>cctv.camera_disable_seconds</c>.</summary>
    public static CctvCameraDisableSecondsCommand CreateGet()
    {
        var cmd = CreatePackage<CctvCameraDisableSecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>cctv.camera_disable_seconds</c> to <paramref name="value"/>.</summary>
    public static CctvCameraDisableSecondsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<CctvCameraDisableSecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
