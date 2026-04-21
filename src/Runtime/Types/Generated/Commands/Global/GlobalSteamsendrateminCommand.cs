using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Minimum send rate clamp, 0 is no limit</summary>
/// <remarks>Full RCON name: <c>global.steamsendratemin</c></remarks>
public sealed class GlobalSteamsendrateminCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.steamsendratemin";

    /// <summary>Reads the current value of <c>global.steamsendratemin</c>.</summary>
    public static GlobalSteamsendrateminCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalSteamsendrateminCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.steamsendratemin</c> to <paramref name="value"/>.</summary>
    public static GlobalSteamsendrateminCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalSteamsendrateminCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
