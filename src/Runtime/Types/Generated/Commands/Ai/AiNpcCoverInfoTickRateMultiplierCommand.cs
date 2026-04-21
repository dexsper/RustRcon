using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The rate at which we gather information about available cover points. Minimum value is 1, as it multiplies with the tick-rate of the fixed AI tick rate of 0.1 (Default: 20)</summary>
/// <remarks>Full RCON name: <c>ai.npc_cover_info_tick_rate_multiplier</c></remarks>
public sealed class AiNpcCoverInfoTickRateMultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_cover_info_tick_rate_multiplier";

    /// <summary>Reads the current value of <c>ai.npc_cover_info_tick_rate_multiplier</c>.</summary>
    public static AiNpcCoverInfoTickRateMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcCoverInfoTickRateMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_cover_info_tick_rate_multiplier</c> to <paramref name="value"/>.</summary>
    public static AiNpcCoverInfoTickRateMultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcCoverInfoTickRateMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
