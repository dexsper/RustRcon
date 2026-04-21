using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Far clipping plane distance in metres for companion server camera renders; default 250</summary>
/// <remarks>Full RCON name: <c>camerarenderer.farplane</c></remarks>
public sealed class CamerarendererFarplaneCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderer.farplane";

    /// <summary>Reads the current value of <c>camerarenderer.farplane</c>.</summary>
    public static CamerarendererFarplaneCommand CreateGet()
    {
        var cmd = CreatePackage<CamerarendererFarplaneCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>camerarenderer.farplane</c> to <paramref name="value"/>.</summary>
    public static CamerarendererFarplaneCommand CreateSet(float value)
    {
        var cmd = CreatePackage<CamerarendererFarplaneCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
