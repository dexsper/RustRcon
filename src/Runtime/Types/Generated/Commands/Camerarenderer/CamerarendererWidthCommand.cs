using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Width in pixels of the companion server camera render output; default 160</summary>
/// <remarks>Full RCON name: <c>camerarenderer.width</c></remarks>
public sealed class CamerarendererWidthCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderer.width";

    /// <summary>Reads the current value of <c>camerarenderer.width</c>.</summary>
    public static CamerarendererWidthCommand CreateGet()
    {
        var cmd = CreatePackage<CamerarendererWidthCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>camerarenderer.width</c> to <paramref name="value"/>.</summary>
    public static CamerarendererWidthCommand CreateSet(int value)
    {
        var cmd = CreatePackage<CamerarendererWidthCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
