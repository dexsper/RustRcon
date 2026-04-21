using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum distance in metres from the companion server camera at which entity colliders are tracked for rendering</summary>
/// <remarks>Full RCON name: <c>camerarenderer.entitymaxdistance</c></remarks>
public sealed class CamerarendererEntitymaxdistanceCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderer.entitymaxdistance";

    /// <summary>Reads the current value of <c>camerarenderer.entitymaxdistance</c>.</summary>
    public static CamerarendererEntitymaxdistanceCommand CreateGet()
    {
        var cmd = CreatePackage<CamerarendererEntitymaxdistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>camerarenderer.entitymaxdistance</c> to <paramref name="value"/>.</summary>
    public static CamerarendererEntitymaxdistanceCommand CreateSet(int value)
    {
        var cmd = CreatePackage<CamerarendererEntitymaxdistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
