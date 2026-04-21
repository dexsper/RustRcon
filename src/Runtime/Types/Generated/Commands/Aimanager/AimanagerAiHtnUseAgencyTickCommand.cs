using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If ai_htn_use_agency_tick is true, the ai manager's agency system will tick htn agents at the ms budgets defined in ai_htn_player_tick_budget and ai_htn_animal_tick_budget. If it's false, each agent registers with the invoke system individually, with no frame-budget restrictions. (default: true)</summary>
/// <remarks>Full RCON name: <c>aimanager.ai_htn_use_agency_tick</c></remarks>
public sealed class AimanagerAiHtnUseAgencyTickCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aimanager.ai_htn_use_agency_tick";

    /// <summary>Reads the current value of <c>aimanager.ai_htn_use_agency_tick</c>.</summary>
    public static AimanagerAiHtnUseAgencyTickCommand CreateGet()
    {
        var cmd = CreatePackage<AimanagerAiHtnUseAgencyTickCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aimanager.ai_htn_use_agency_tick</c> to <paramref name="value"/>.</summary>
    public static AimanagerAiHtnUseAgencyTickCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AimanagerAiHtnUseAgencyTickCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
