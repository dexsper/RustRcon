using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The rate at which we tick the sensory system. Minimum value is 1, as it multiplies with the tick-rate of the fixed AI tick rate of 0.1 (Default: 5)</summary>
/// <remarks>Full RCON name: <c>ai.npc_sensory_system_tick_rate_multiplier</c></remarks>
public sealed class AiNpcSensorySystemTickRateMultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_sensory_system_tick_rate_multiplier";

    /// <summary>Reads the current value of <c>ai.npc_sensory_system_tick_rate_multiplier</c>.</summary>
    public static AiNpcSensorySystemTickRateMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcSensorySystemTickRateMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_sensory_system_tick_rate_multiplier</c> to <paramref name="value"/>.</summary>
    public static AiNpcSensorySystemTickRateMultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcSensorySystemTickRateMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
