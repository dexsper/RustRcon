using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>global.steamnetdebug_p2prendezvous</c>.</summary>
/// <remarks>Full RCON name: <c>global.steamnetdebug_p2prendezvous</c></remarks>
public sealed class GlobalSteamnetdebugP2prendezvousCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.steamnetdebug_p2prendezvous";

    /// <summary>Reads the current value of <c>global.steamnetdebug_p2prendezvous</c>.</summary>
    public static GlobalSteamnetdebugP2prendezvousCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalSteamnetdebugP2prendezvousCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.steamnetdebug_p2prendezvous</c> to <paramref name="value"/>.</summary>
    public static GlobalSteamnetdebugP2prendezvousCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalSteamnetdebugP2prendezvousCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
