using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If ai_dormant is true, any npc outside the range of players will render itself dormant and take up less resources, but wildlife won't simulate as well.</summary>
/// <remarks>Full RCON name: <c>aimanager.ai_dormant</c></remarks>
public sealed class AimanagerAiDormantCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aimanager.ai_dormant";

    /// <summary>Reads the current value of <c>aimanager.ai_dormant</c>.</summary>
    public static AimanagerAiDormantCommand CreateGet()
    {
        var cmd = CreatePackage<AimanagerAiDormantCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aimanager.ai_dormant</c> to <paramref name="value"/>.</summary>
    public static AimanagerAiDormantCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AimanagerAiDormantCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
