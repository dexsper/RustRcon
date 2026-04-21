using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Global multiplier applied to wildlife hazard reaction time; higher values make hazards slower to react to player presence</summary>
/// <remarks>Full RCON name: <c>wildlifehazard.reactiontimemultiplier</c></remarks>
public sealed class WildlifehazardReactiontimemultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "wildlifehazard.reactiontimemultiplier";

    /// <summary>Reads the current value of <c>wildlifehazard.reactiontimemultiplier</c>.</summary>
    public static WildlifehazardReactiontimemultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<WildlifehazardReactiontimemultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>wildlifehazard.reactiontimemultiplier</c> to <paramref name="value"/>.</summary>
    public static WildlifehazardReactiontimemultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WildlifehazardReactiontimemultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
