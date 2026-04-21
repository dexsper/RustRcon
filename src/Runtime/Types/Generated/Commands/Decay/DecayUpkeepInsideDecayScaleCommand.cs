using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Scale at which objects decay when they are inside, default of 0.1</summary>
/// <remarks>Full RCON name: <c>decay.upkeep_inside_decay_scale</c></remarks>
public sealed class DecayUpkeepInsideDecayScaleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.upkeep_inside_decay_scale";

    /// <summary>Reads the current value of <c>decay.upkeep_inside_decay_scale</c>.</summary>
    public static DecayUpkeepInsideDecayScaleCommand CreateGet()
    {
        var cmd = CreatePackage<DecayUpkeepInsideDecayScaleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.upkeep_inside_decay_scale</c> to <paramref name="value"/>.</summary>
    public static DecayUpkeepInsideDecayScaleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayUpkeepInsideDecayScaleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
