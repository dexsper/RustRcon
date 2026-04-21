using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>global.steamnagleflush</c>.</summary>
/// <remarks>Full RCON name: <c>global.steamnagleflush</c></remarks>
public sealed class GlobalSteamnagleflushCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.steamnagleflush";

    /// <summary>Reads the current value of <c>global.steamnagleflush</c>.</summary>
    public static GlobalSteamnagleflushCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalSteamnagleflushCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.steamnagleflush</c> to <paramref name="value"/>.</summary>
    public static GlobalSteamnagleflushCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<GlobalSteamnagleflushCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
