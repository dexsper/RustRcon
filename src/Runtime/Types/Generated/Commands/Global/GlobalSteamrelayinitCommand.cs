using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>global.steamrelayinit</c>.</summary>
/// <remarks>Full RCON name: <c>global.steamrelayinit</c></remarks>
public sealed class GlobalSteamrelayinitCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.steamrelayinit";

    /// <summary>Creates a new <see cref="GlobalSteamrelayinitCommand"/> command.</summary>
    public static GlobalSteamrelayinitCommand Create()
    {
        var cmd = CreatePackage<GlobalSteamrelayinitCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
