using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum distance in metres at which player name labels are included in companion server camera render output</summary>
/// <remarks>Full RCON name: <c>camerarenderer.playernamemaxdistance</c></remarks>
public sealed class CamerarendererPlayernamemaxdistanceCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderer.playernamemaxdistance";

    /// <summary>Reads the current value of <c>camerarenderer.playernamemaxdistance</c>.</summary>
    public static CamerarendererPlayernamemaxdistanceCommand CreateGet()
    {
        var cmd = CreatePackage<CamerarendererPlayernamemaxdistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>camerarenderer.playernamemaxdistance</c> to <paramref name="value"/>.</summary>
    public static CamerarendererPlayernamemaxdistanceCommand CreateSet(int value)
    {
        var cmd = CreatePackage<CamerarendererPlayernamemaxdistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
