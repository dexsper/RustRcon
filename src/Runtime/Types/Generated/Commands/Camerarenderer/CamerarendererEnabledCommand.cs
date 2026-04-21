using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, the companion server camera rendering system is active and processes camera render requests from the companion app</summary>
/// <remarks>Full RCON name: <c>camerarenderer.enabled</c></remarks>
public sealed class CamerarendererEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderer.enabled";

    /// <summary>Reads the current value of <c>camerarenderer.enabled</c>.</summary>
    public static CamerarendererEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<CamerarendererEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>camerarenderer.enabled</c> to <paramref name="value"/>.</summary>
    public static CamerarendererEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CamerarendererEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
