using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>global.steamnetdebug_message</c>.</summary>
/// <remarks>Full RCON name: <c>global.steamnetdebug_message</c></remarks>
public sealed class GlobalSteamnetdebugMessageCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.steamnetdebug_message";

    /// <summary>Reads the current value of <c>global.steamnetdebug_message</c>.</summary>
    public static GlobalSteamnetdebugMessageCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalSteamnetdebugMessageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.steamnetdebug_message</c> to <paramref name="value"/>.</summary>
    public static GlobalSteamnetdebugMessageCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalSteamnetdebugMessageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
