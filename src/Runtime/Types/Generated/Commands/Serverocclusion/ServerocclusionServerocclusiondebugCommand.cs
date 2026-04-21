using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Tests occlusion visibility between two positions</summary>
/// <remarks>Full RCON name: <c>serverocclusion.serverocclusiondebug</c></remarks>
public sealed class ServerocclusionServerocclusiondebugCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "serverocclusion.serverocclusiondebug";

    /// <summary>Creates a new <see cref="ServerocclusionServerocclusiondebugCommand"/> command.</summary>
    public static ServerocclusionServerocclusiondebugCommand Create()
    {
        var cmd = CreatePackage<ServerocclusionServerocclusiondebugCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
