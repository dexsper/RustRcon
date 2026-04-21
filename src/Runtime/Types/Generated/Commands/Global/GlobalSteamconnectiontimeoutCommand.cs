using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>global.steamconnectiontimeout</c>.</summary>
/// <remarks>Full RCON name: <c>global.steamconnectiontimeout</c></remarks>
public sealed class GlobalSteamconnectiontimeoutCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.steamconnectiontimeout";

    /// <summary>Reads the current value of <c>global.steamconnectiontimeout</c>.</summary>
    public static GlobalSteamconnectiontimeoutCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalSteamconnectiontimeoutCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.steamconnectiontimeout</c> to <paramref name="value"/>.</summary>
    public static GlobalSteamconnectiontimeoutCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalSteamconnectiontimeoutCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
