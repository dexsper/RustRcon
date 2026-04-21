using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of camera render tasks that can complete per frame for companion server cameras</summary>
/// <remarks>Full RCON name: <c>camerarenderer.maxrendersperframe</c></remarks>
public sealed class CamerarendererMaxrendersperframeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderer.maxrendersperframe";

    /// <summary>Reads the current value of <c>camerarenderer.maxrendersperframe</c>.</summary>
    public static CamerarendererMaxrendersperframeCommand CreateGet()
    {
        var cmd = CreatePackage<CamerarendererMaxrendersperframeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>camerarenderer.maxrendersperframe</c> to <paramref name="value"/>.</summary>
    public static CamerarendererMaxrendersperframeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<CamerarendererMaxrendersperframeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
