using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Global multiplier applied to the cooldown timer between wildlife hazard reposition attempts</summary>
/// <remarks>Full RCON name: <c>wildlifehazard.repositiontimermultiplier</c></remarks>
public sealed class WildlifehazardRepositiontimermultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "wildlifehazard.repositiontimermultiplier";

    /// <summary>Reads the current value of <c>wildlifehazard.repositiontimermultiplier</c>.</summary>
    public static WildlifehazardRepositiontimermultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<WildlifehazardRepositiontimermultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>wildlifehazard.repositiontimermultiplier</c> to <paramref name="value"/>.</summary>
    public static WildlifehazardRepositiontimermultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WildlifehazardRepositiontimermultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
