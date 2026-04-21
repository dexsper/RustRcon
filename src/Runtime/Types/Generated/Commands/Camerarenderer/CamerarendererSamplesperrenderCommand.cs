using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of raycast samples taken per companion server camera render pass for depth reconstruction</summary>
/// <remarks>Full RCON name: <c>camerarenderer.samplesperrender</c></remarks>
public sealed class CamerarendererSamplesperrenderCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderer.samplesperrender";

    /// <summary>Reads the current value of <c>camerarenderer.samplesperrender</c>.</summary>
    public static CamerarendererSamplesperrenderCommand CreateGet()
    {
        var cmd = CreatePackage<CamerarendererSamplesperrenderCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>camerarenderer.samplesperrender</c> to <paramref name="value"/>.</summary>
    public static CamerarendererSamplesperrenderCommand CreateSet(int value)
    {
        var cmd = CreatePackage<CamerarendererSamplesperrenderCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
