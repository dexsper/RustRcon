using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Developer mode level: 0 = off, 1 = developer overlays and convar unlocks, higher values enable increasingly verbose debug logging</summary>
/// <remarks>Full RCON name: <c>global.developer</c></remarks>
public sealed class GlobalDeveloperCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.developer";

    /// <summary>Reads the current value of <c>global.developer</c>.</summary>
    public static GlobalDeveloperCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalDeveloperCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.developer</c> to <paramref name="value"/>.</summary>
    public static GlobalDeveloperCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalDeveloperCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
