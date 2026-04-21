using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Show user info for players on server.</summary>
/// <remarks>Full RCON name: <c>global.users</c></remarks>
public sealed class GlobalUsersCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.users";

    /// <summary>Creates a new <see cref="GlobalUsersCommand"/> command.</summary>
    public static GlobalUsersCommand Create()
    {
        var cmd = CreatePackage<GlobalUsersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
