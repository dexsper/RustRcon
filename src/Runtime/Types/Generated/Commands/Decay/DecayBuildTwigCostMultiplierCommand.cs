using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Can players upgrade building blocks to wood</summary>
/// <remarks>Full RCON name: <c>decay.build_twig_cost_multiplier</c></remarks>
public sealed class DecayBuildTwigCostMultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.build_twig_cost_multiplier";

    /// <summary>Reads the current value of <c>decay.build_twig_cost_multiplier</c>.</summary>
    public static DecayBuildTwigCostMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<DecayBuildTwigCostMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.build_twig_cost_multiplier</c> to <paramref name="value"/>.</summary>
    public static DecayBuildTwigCostMultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayBuildTwigCostMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
