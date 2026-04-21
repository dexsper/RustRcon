using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Show holstered items on player bodies</summary>
/// <remarks>Full RCON name: <c>server.setshowholstereditems</c></remarks>
public sealed class ServerSetshowholstereditemsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.setshowholstereditems";

    /// <summary>Creates a new <see cref="ServerSetshowholstereditemsCommand"/> command.</summary>
    public static ServerSetshowholstereditemsCommand Create(bool value)
    {
        var cmd = CreatePackage<ServerSetshowholstereditemsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
