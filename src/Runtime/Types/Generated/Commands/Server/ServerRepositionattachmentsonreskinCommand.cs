using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Reposition attachments like storage adaptors if they have moved on reskins</summary>
/// <remarks>Full RCON name: <c>server.repositionattachmentsonreskin</c></remarks>
public sealed class ServerRepositionattachmentsonreskinCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.repositionattachmentsonreskin";

    /// <summary>Reads the current value of <c>server.repositionattachmentsonreskin</c>.</summary>
    public static ServerRepositionattachmentsonreskinCommand CreateGet()
    {
        var cmd = CreatePackage<ServerRepositionattachmentsonreskinCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.repositionattachmentsonreskin</c> to <paramref name="value"/>.</summary>
    public static ServerRepositionattachmentsonreskinCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerRepositionattachmentsonreskinCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
