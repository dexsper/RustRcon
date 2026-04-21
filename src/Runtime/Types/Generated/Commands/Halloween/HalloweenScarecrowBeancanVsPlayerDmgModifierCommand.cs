using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Modified damage from beancan explosion vs players (Default: 0.1).</summary>
/// <remarks>Full RCON name: <c>halloween.scarecrow_beancan_vs_player_dmg_modifier</c></remarks>
public sealed class HalloweenScarecrowBeancanVsPlayerDmgModifierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "halloween.scarecrow_beancan_vs_player_dmg_modifier";

    /// <summary>Reads the current value of <c>halloween.scarecrow_beancan_vs_player_dmg_modifier</c>.</summary>
    public static HalloweenScarecrowBeancanVsPlayerDmgModifierCommand CreateGet()
    {
        var cmd = CreatePackage<HalloweenScarecrowBeancanVsPlayerDmgModifierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>halloween.scarecrow_beancan_vs_player_dmg_modifier</c> to <paramref name="value"/>.</summary>
    public static HalloweenScarecrowBeancanVsPlayerDmgModifierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HalloweenScarecrowBeancanVsPlayerDmgModifierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
