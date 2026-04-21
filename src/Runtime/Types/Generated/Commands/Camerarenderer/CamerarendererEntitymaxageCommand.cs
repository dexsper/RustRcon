using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum age in frames for a known collider entity entry in the companion server camera cache before it is evicted</summary>
/// <remarks>Full RCON name: <c>camerarenderer.entitymaxage</c></remarks>
public sealed class CamerarendererEntitymaxageCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderer.entitymaxage";

    /// <summary>Reads the current value of <c>camerarenderer.entitymaxage</c>.</summary>
    public static CamerarendererEntitymaxageCommand CreateGet()
    {
        var cmd = CreatePackage<CamerarendererEntitymaxageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>camerarenderer.entitymaxage</c> to <paramref name="value"/>.</summary>
    public static CamerarendererEntitymaxageCommand CreateSet(int value)
    {
        var cmd = CreatePackage<CamerarendererEntitymaxageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
