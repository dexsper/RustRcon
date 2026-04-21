using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Per-frame CPU budget in milliseconds for completing pending companion server camera renders</summary>
/// <remarks>Full RCON name: <c>camerarenderer.completionframebudgetms</c></remarks>
public sealed class CamerarendererCompletionframebudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderer.completionframebudgetms";

    /// <summary>Reads the current value of <c>camerarenderer.completionframebudgetms</c>.</summary>
    public static CamerarendererCompletionframebudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<CamerarendererCompletionframebudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>camerarenderer.completionframebudgetms</c> to <paramref name="value"/>.</summary>
    public static CamerarendererCompletionframebudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<CamerarendererCompletionframebudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
