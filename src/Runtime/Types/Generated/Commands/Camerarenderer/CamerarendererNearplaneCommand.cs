using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Near clipping plane distance for companion server camera renders; 0 = use default</summary>
/// <remarks>Full RCON name: <c>camerarenderer.nearplane</c></remarks>
public sealed class CamerarendererNearplaneCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderer.nearplane";

    /// <summary>Reads the current value of <c>camerarenderer.nearplane</c>.</summary>
    public static CamerarendererNearplaneCommand CreateGet()
    {
        var cmd = CreatePackage<CamerarendererNearplaneCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>camerarenderer.nearplane</c> to <paramref name="value"/>.</summary>
    public static CamerarendererNearplaneCommand CreateSet(float value)
    {
        var cmd = CreatePackage<CamerarendererNearplaneCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
