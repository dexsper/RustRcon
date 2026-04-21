using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>note.update</c>.</summary>
/// <remarks>Full RCON name: <c>note.update</c></remarks>
public sealed class NoteUpdateCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "note.update";

    /// <summary>Creates a new <see cref="NoteUpdateCommand"/> command.</summary>
    public static NoteUpdateCommand Create()
    {
        var cmd = CreatePackage<NoteUpdateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
