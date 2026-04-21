using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of raycasts per frame used for companion server camera depth sampling</summary>
/// <remarks>Full RCON name: <c>camerarenderer.maxraysperframe</c></remarks>
public sealed class CamerarendererMaxraysperframeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderer.maxraysperframe";

    /// <summary>Reads the current value of <c>camerarenderer.maxraysperframe</c>.</summary>
    public static CamerarendererMaxraysperframeCommand CreateGet()
    {
        var cmd = CreatePackage<CamerarendererMaxraysperframeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>camerarenderer.maxraysperframe</c> to <paramref name="value"/>.</summary>
    public static CamerarendererMaxraysperframeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<CamerarendererMaxraysperframeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
