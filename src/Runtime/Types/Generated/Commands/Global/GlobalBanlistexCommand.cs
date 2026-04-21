using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>List of banned users - shows reasons and usernames</summary>
/// <remarks>Full RCON name: <c>global.banlistex</c></remarks>
public sealed class GlobalBanlistexCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.banlistex";

    /// <summary>Creates a new <see cref="GlobalBanlistexCommand"/> command.</summary>
    public static GlobalBanlistexCommand Create()
    {
        var cmd = CreatePackage<GlobalBanlistexCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
