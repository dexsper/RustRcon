using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Instantly kills the player boat directly in front of the calling admin player; admin-only dev command</summary>
/// <remarks>Full RCON name: <c>playerboat.sink</c></remarks>
public sealed class PlayerboatSinkCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.sink";

    /// <summary>Creates a new <see cref="PlayerboatSinkCommand"/> command.</summary>
    public static PlayerboatSinkCommand Create()
    {
        var cmd = CreatePackage<PlayerboatSinkCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
