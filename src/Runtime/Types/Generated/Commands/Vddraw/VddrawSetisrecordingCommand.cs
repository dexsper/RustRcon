using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Toggles or explicitly sets VDDraw recording state; when enabled starts capturing DDraw commands for replay; when disabled stops recording</summary>
/// <remarks>Full RCON name: <c>vddraw.setisrecording</c></remarks>
public sealed class VddrawSetisrecordingCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vddraw.setisrecording";

    /// <summary>Creates a new <see cref="VddrawSetisrecordingCommand"/> command.</summary>
    public static VddrawSetisrecordingCommand Create()
    {
        var cmd = CreatePackage<VddrawSetisrecordingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
