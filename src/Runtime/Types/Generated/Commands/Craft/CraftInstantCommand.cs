using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, all crafting completes instantly with no time delay; useful for testing crafting recipes or quickly equipping items in development</summary>
/// <remarks>Full RCON name: <c>craft.instant</c></remarks>
public sealed class CraftInstantCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "craft.instant";

    /// <summary>Reads the current value of <c>craft.instant</c>.</summary>
    public static CraftInstantCommand CreateGet()
    {
        var cmd = CreatePackage<CraftInstantCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>craft.instant</c> to <paramref name="value"/>.</summary>
    public static CraftInstantCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CraftInstantCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
