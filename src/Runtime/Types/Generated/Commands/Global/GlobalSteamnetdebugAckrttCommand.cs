using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>global.steamnetdebug_ackrtt</c>.</summary>
/// <remarks>Full RCON name: <c>global.steamnetdebug_ackrtt</c></remarks>
public sealed class GlobalSteamnetdebugAckrttCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.steamnetdebug_ackrtt";

    /// <summary>Reads the current value of <c>global.steamnetdebug_ackrtt</c>.</summary>
    public static GlobalSteamnetdebugAckrttCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalSteamnetdebugAckrttCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.steamnetdebug_ackrtt</c> to <paramref name="value"/>.</summary>
    public static GlobalSteamnetdebugAckrttCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalSteamnetdebugAckrttCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
