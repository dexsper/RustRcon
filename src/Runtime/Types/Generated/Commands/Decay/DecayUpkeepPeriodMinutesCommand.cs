using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many minutes does the upkeep cost last? default : 1440 (24 hours)</summary>
/// <remarks>Full RCON name: <c>decay.upkeep_period_minutes</c></remarks>
public sealed class DecayUpkeepPeriodMinutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.upkeep_period_minutes";

    /// <summary>Reads the current value of <c>decay.upkeep_period_minutes</c>.</summary>
    public static DecayUpkeepPeriodMinutesCommand CreateGet()
    {
        var cmd = CreatePackage<DecayUpkeepPeriodMinutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.upkeep_period_minutes</c> to <paramref name="value"/>.</summary>
    public static DecayUpkeepPeriodMinutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayUpkeepPeriodMinutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
