using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Physics layer mask used for raycasting in companion server camera depth sampling; defaults to solid, water, and player movement layers</summary>
/// <remarks>Full RCON name: <c>camerarenderer.layermask</c></remarks>
public sealed class CamerarendererLayermaskCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderer.layermask";

    /// <summary>Reads the current value of <c>camerarenderer.layermask</c>.</summary>
    public static CamerarendererLayermaskCommand CreateGet()
    {
        var cmd = CreatePackage<CamerarendererLayermaskCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>camerarenderer.layermask</c> to <paramref name="value"/>.</summary>
    public static CamerarendererLayermaskCommand CreateSet(int value)
    {
        var cmd = CreatePackage<CamerarendererLayermaskCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
