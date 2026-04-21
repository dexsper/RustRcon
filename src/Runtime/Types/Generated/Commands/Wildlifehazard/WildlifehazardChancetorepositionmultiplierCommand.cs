using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Global multiplier applied to the per-tick probability that a wildlife hazard attempts to reposition</summary>
/// <remarks>Full RCON name: <c>wildlifehazard.chancetorepositionmultiplier</c></remarks>
public sealed class WildlifehazardChancetorepositionmultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "wildlifehazard.chancetorepositionmultiplier";

    /// <summary>Reads the current value of <c>wildlifehazard.chancetorepositionmultiplier</c>.</summary>
    public static WildlifehazardChancetorepositionmultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<WildlifehazardChancetorepositionmultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>wildlifehazard.chancetorepositionmultiplier</c> to <paramref name="value"/>.</summary>
    public static WildlifehazardChancetorepositionmultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WildlifehazardChancetorepositionmultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
