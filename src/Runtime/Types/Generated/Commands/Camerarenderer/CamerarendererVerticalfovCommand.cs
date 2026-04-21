using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Vertical field of view in degrees for companion server camera renders; default 65</summary>
/// <remarks>Full RCON name: <c>camerarenderer.verticalfov</c></remarks>
public sealed class CamerarendererVerticalfovCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderer.verticalfov";

    /// <summary>Reads the current value of <c>camerarenderer.verticalfov</c>.</summary>
    public static CamerarendererVerticalfovCommand CreateGet()
    {
        var cmd = CreatePackage<CamerarendererVerticalfovCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>camerarenderer.verticalfov</c> to <paramref name="value"/>.</summary>
    public static CamerarendererVerticalfovCommand CreateSet(float value)
    {
        var cmd = CreatePackage<CamerarendererVerticalfovCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
