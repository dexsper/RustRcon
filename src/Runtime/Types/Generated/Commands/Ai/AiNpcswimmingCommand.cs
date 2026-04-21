using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, NPCs can enter and swim in water; disable to prevent all NPCs from entering water bodies</summary>
/// <remarks>Full RCON name: <c>ai.npcswimming</c></remarks>
public sealed class AiNpcswimmingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npcswimming";

    /// <summary>Reads the current value of <c>ai.npcswimming</c>.</summary>
    public static AiNpcswimmingCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcswimmingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npcswimming</c> to <paramref name="value"/>.</summary>
    public static AiNpcswimmingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiNpcswimmingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
