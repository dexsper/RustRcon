using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many milliseconds to spend on target scanning per frame</summary>
/// <remarks>Full RCON name: <c>guntrap.gun_trap_budget_ms</c></remarks>
public sealed class GuntrapGunTrapBudgetMsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "guntrap.gun_trap_budget_ms";

    /// <summary>Reads the current value of <c>guntrap.gun_trap_budget_ms</c>.</summary>
    public static GuntrapGunTrapBudgetMsCommand CreateGet()
    {
        var cmd = CreatePackage<GuntrapGunTrapBudgetMsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>guntrap.gun_trap_budget_ms</c> to <paramref name="value"/>.</summary>
    public static GuntrapGunTrapBudgetMsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<GuntrapGunTrapBudgetMsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
