using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Bans a player by Steam ID from the server via the app layer, adding them to the banlist and kicking them if connected</summary>
/// <remarks>Full RCON name: <c>app.appban</c></remarks>
public sealed class AppAppbanCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "app.appban";

    /// <summary>Creates a new <see cref="AppAppbanCommand"/> command.</summary>
    public static AppAppbanCommand Create(ulong uLong)
    {
        var cmd = CreatePackage<AppAppbanCommand>();
        cmd.Content = $"{CommandFullName} {uLong}";
        return cmd;
    }
}
