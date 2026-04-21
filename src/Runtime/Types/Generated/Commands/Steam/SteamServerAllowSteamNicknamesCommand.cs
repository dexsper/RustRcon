using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>steam.server_allow_steam_nicknames</c>.</summary>
/// <remarks>Full RCON name: <c>steam.server_allow_steam_nicknames</c></remarks>
public sealed class SteamServerAllowSteamNicknamesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "steam.server_allow_steam_nicknames";

    /// <summary>Reads the current value of <c>steam.server_allow_steam_nicknames</c>.</summary>
    public static SteamServerAllowSteamNicknamesCommand CreateGet()
    {
        var cmd = CreatePackage<SteamServerAllowSteamNicknamesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>steam.server_allow_steam_nicknames</c> to <paramref name="value"/>.</summary>
    public static SteamServerAllowSteamNicknamesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<SteamServerAllowSteamNicknamesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
