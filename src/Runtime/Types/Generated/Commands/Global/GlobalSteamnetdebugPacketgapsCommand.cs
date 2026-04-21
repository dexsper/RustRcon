using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>global.steamnetdebug_packetgaps</c>.</summary>
/// <remarks>Full RCON name: <c>global.steamnetdebug_packetgaps</c></remarks>
public sealed class GlobalSteamnetdebugPacketgapsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.steamnetdebug_packetgaps";

    /// <summary>Reads the current value of <c>global.steamnetdebug_packetgaps</c>.</summary>
    public static GlobalSteamnetdebugPacketgapsCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalSteamnetdebugPacketgapsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.steamnetdebug_packetgaps</c> to <paramref name="value"/>.</summary>
    public static GlobalSteamnetdebugPacketgapsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalSteamnetdebugPacketgapsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
