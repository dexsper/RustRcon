using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in seconds between successive companion server camera render dispatches; default 0.05s (20 Hz)</summary>
/// <remarks>Full RCON name: <c>camerarenderer.renderinterval</c></remarks>
public sealed class CamerarendererRenderintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderer.renderinterval";

    /// <summary>Reads the current value of <c>camerarenderer.renderinterval</c>.</summary>
    public static CamerarendererRenderintervalCommand CreateGet()
    {
        var cmd = CreatePackage<CamerarendererRenderintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>camerarenderer.renderinterval</c> to <paramref name="value"/>.</summary>
    public static CamerarendererRenderintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<CamerarendererRenderintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
