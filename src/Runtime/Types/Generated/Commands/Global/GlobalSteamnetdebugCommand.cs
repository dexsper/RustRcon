using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Turns on varying levels of debug output for the Steam Networking. This will affect performance. (0 = off, 1 = bug, 2 = error, 3 = important, 4 = warning, 5 = message, 6 = verbose, 7 = debug, 8 = everything)</summary>
/// <remarks>Full RCON name: <c>global.steamnetdebug</c></remarks>
public sealed class GlobalSteamnetdebugCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.steamnetdebug";

    /// <summary>Reads the current value of <c>global.steamnetdebug</c>.</summary>
    public static GlobalSteamnetdebugCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalSteamnetdebugCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.steamnetdebug</c> to <paramref name="value"/>.</summary>
    public static GlobalSteamnetdebugCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalSteamnetdebugCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
