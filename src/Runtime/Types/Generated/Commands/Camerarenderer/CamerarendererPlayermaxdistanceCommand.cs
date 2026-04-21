using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum distance in metres at which player entities are included in companion server camera renders</summary>
/// <remarks>Full RCON name: <c>camerarenderer.playermaxdistance</c></remarks>
public sealed class CamerarendererPlayermaxdistanceCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderer.playermaxdistance";

    /// <summary>Reads the current value of <c>camerarenderer.playermaxdistance</c>.</summary>
    public static CamerarendererPlayermaxdistanceCommand CreateGet()
    {
        var cmd = CreatePackage<CamerarendererPlayermaxdistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>camerarenderer.playermaxdistance</c> to <paramref name="value"/>.</summary>
    public static CamerarendererPlayermaxdistanceCommand CreateSet(int value)
    {
        var cmd = CreatePackage<CamerarendererPlayermaxdistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
