using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many minutes can the upkeep cost last after the cupboard was destroyed? default : 1440 (24 hours)</summary>
/// <remarks>Full RCON name: <c>decay.upkeep_grief_protection</c></remarks>
public sealed class DecayUpkeepGriefProtectionCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.upkeep_grief_protection";

    /// <summary>Reads the current value of <c>decay.upkeep_grief_protection</c>.</summary>
    public static DecayUpkeepGriefProtectionCommand CreateGet()
    {
        var cmd = CreatePackage<DecayUpkeepGriefProtectionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.upkeep_grief_protection</c> to <paramref name="value"/>.</summary>
    public static DecayUpkeepGriefProtectionCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayUpkeepGriefProtectionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
