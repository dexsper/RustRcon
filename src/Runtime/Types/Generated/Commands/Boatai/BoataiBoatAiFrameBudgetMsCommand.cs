using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long per frame to spend on boat ai</summary>
/// <remarks>Full RCON name: <c>boatai.boat_ai_frame_budget_ms</c></remarks>
public sealed class BoataiBoatAiFrameBudgetMsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatai.boat_ai_frame_budget_ms";

    /// <summary>Reads the current value of <c>boatai.boat_ai_frame_budget_ms</c>.</summary>
    public static BoataiBoatAiFrameBudgetMsCommand CreateGet()
    {
        var cmd = CreatePackage<BoataiBoatAiFrameBudgetMsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatai.boat_ai_frame_budget_ms</c> to <paramref name="value"/>.</summary>
    public static BoataiBoatAiFrameBudgetMsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BoataiBoatAiFrameBudgetMsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
