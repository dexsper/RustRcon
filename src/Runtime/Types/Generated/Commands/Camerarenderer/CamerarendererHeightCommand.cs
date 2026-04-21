using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Height in pixels of the companion server camera render output; default 90</summary>
/// <remarks>Full RCON name: <c>camerarenderer.height</c></remarks>
public sealed class CamerarendererHeightCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderer.height";

    /// <summary>Reads the current value of <c>camerarenderer.height</c>.</summary>
    public static CamerarendererHeightCommand CreateGet()
    {
        var cmd = CreatePackage<CamerarendererHeightCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>camerarenderer.height</c> to <paramref name="value"/>.</summary>
    public static CamerarendererHeightCommand CreateSet(int value)
    {
        var cmd = CreatePackage<CamerarendererHeightCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
