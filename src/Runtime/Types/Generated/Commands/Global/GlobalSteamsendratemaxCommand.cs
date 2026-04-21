using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Maxminum send rate clamp, 0 is no limit</summary>
/// <remarks>Full RCON name: <c>global.steamsendratemax</c></remarks>
public sealed class GlobalSteamsendratemaxCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.steamsendratemax";

    /// <summary>Reads the current value of <c>global.steamsendratemax</c>.</summary>
    public static GlobalSteamsendratemaxCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalSteamsendratemaxCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.steamsendratemax</c> to <paramref name="value"/>.</summary>
    public static GlobalSteamsendratemaxCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalSteamsendratemaxCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
