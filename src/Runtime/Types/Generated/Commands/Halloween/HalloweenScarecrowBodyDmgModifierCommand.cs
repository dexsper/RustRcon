using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Modifier to how much damage scarecrows take to the body. (Default: 0.25)</summary>
/// <remarks>Full RCON name: <c>halloween.scarecrow_body_dmg_modifier</c></remarks>
public sealed class HalloweenScarecrowBodyDmgModifierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "halloween.scarecrow_body_dmg_modifier";

    /// <summary>Reads the current value of <c>halloween.scarecrow_body_dmg_modifier</c>.</summary>
    public static HalloweenScarecrowBodyDmgModifierCommand CreateGet()
    {
        var cmd = CreatePackage<HalloweenScarecrowBodyDmgModifierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>halloween.scarecrow_body_dmg_modifier</c> to <paramref name="value"/>.</summary>
    public static HalloweenScarecrowBodyDmgModifierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HalloweenScarecrowBodyDmgModifierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
