using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Opens all sails on the player boat directly in front of the calling admin player; admin-only dev command</summary>
/// <remarks>Full RCON name: <c>playerboat.setsailsopen</c></remarks>
public sealed class PlayerboatSetsailsopenCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.setsailsopen";

    /// <summary>Creates a new <see cref="PlayerboatSetsailsopenCommand"/> command.</summary>
    public static PlayerboatSetsailsopenCommand Create()
    {
        var cmd = CreatePackage<PlayerboatSetsailsopenCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
