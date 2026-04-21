using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>List of banned users (sourceds compat)</summary>
/// <remarks>Full RCON name: <c>global.banlist</c></remarks>
public sealed class GlobalBanlistCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.banlist";

    /// <summary>Creates a new <see cref="GlobalBanlistCommand"/> command.</summary>
    public static GlobalBanlistCommand Create()
    {
        var cmd = CreatePackage<GlobalBanlistCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
