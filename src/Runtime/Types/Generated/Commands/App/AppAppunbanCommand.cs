using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Removes a ban for the specified Steam ID from the server banlist, allowing the player to reconnect</summary>
/// <remarks>Full RCON name: <c>app.appunban</c></remarks>
public sealed class AppAppunbanCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "app.appunban";

    /// <summary>Creates a new <see cref="AppAppunbanCommand"/> command.</summary>
    public static AppAppunbanCommand Create(ulong uLong)
    {
        var cmd = CreatePackage<AppAppunbanCommand>();
        cmd.Content = $"{CommandFullName} {uLong}";
        return cmd;
    }
}
