using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>ai_htn_player_tick_budget defines the maximum amount of milliseconds ticking htn player agents are allowed to consume. (default: 4 ms)</summary>
/// <remarks>Full RCON name: <c>aimanager.ai_htn_player_tick_budget</c></remarks>
public sealed class AimanagerAiHtnPlayerTickBudgetCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aimanager.ai_htn_player_tick_budget";

    /// <summary>Reads the current value of <c>aimanager.ai_htn_player_tick_budget</c>.</summary>
    public static AimanagerAiHtnPlayerTickBudgetCommand CreateGet()
    {
        var cmd = CreatePackage<AimanagerAiHtnPlayerTickBudgetCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aimanager.ai_htn_player_tick_budget</c> to <paramref name="value"/>.</summary>
    public static AimanagerAiHtnPlayerTickBudgetCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AimanagerAiHtnPlayerTickBudgetCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
