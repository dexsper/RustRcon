using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>List of banned users, by ID (sourceds compat)</summary>
/// <remarks>Full RCON name: <c>global.listid</c></remarks>
public sealed class GlobalListidCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.listid";

    /// <summary>Creates a new <see cref="GlobalListidCommand"/> command.</summary>
    public static GlobalListidCommand Create()
    {
        var cmd = CreatePackage<GlobalListidCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
