using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Upper limit of buffered pending bytes to be sent</summary>
/// <remarks>Full RCON name: <c>global.steamsendbuffer</c></remarks>
public sealed class GlobalSteamsendbufferCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.steamsendbuffer";

    /// <summary>Reads the current value of <c>global.steamsendbuffer</c>.</summary>
    public static GlobalSteamsendbufferCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalSteamsendbufferCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.steamsendbuffer</c> to <paramref name="value"/>.</summary>
    public static GlobalSteamsendbufferCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalSteamsendbufferCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
