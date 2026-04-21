using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>global.steamnetdebug_packetdecode</c>.</summary>
/// <remarks>Full RCON name: <c>global.steamnetdebug_packetdecode</c></remarks>
public sealed class GlobalSteamnetdebugPacketdecodeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.steamnetdebug_packetdecode";

    /// <summary>Reads the current value of <c>global.steamnetdebug_packetdecode</c>.</summary>
    public static GlobalSteamnetdebugPacketdecodeCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalSteamnetdebugPacketdecodeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.steamnetdebug_packetdecode</c> to <paramref name="value"/>.</summary>
    public static GlobalSteamnetdebugPacketdecodeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalSteamnetdebugPacketdecodeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
