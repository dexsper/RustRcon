using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>global.steamnetdebug_sdrrelaypings</c>.</summary>
/// <remarks>Full RCON name: <c>global.steamnetdebug_sdrrelaypings</c></remarks>
public sealed class GlobalSteamnetdebugSdrrelaypingsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.steamnetdebug_sdrrelaypings";

    /// <summary>Reads the current value of <c>global.steamnetdebug_sdrrelaypings</c>.</summary>
    public static GlobalSteamnetdebugSdrrelaypingsCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalSteamnetdebugSdrrelaypingsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.steamnetdebug_sdrrelaypings</c> to <paramref name="value"/>.</summary>
    public static GlobalSteamnetdebugSdrrelaypingsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalSteamnetdebugSdrrelaypingsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
