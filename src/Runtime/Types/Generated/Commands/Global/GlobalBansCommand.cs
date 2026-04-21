using RustRcon.Types;
using RustRcon.Types.Commands.Base;
using RustRcon.Generated.Dtos;

namespace RustRcon.Generated.Commands;

/// <summary>List of banned users</summary>
/// <remarks>Full RCON name: <c>global.bans</c></remarks>
public sealed class GlobalBansCommand : BaseCallCommand<User[]>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.bans";

    /// <summary>Creates a new <see cref="GlobalBansCommand"/> command.</summary>
    public static GlobalBansCommand Create()
    {
        var cmd = CreatePackage<GlobalBansCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
