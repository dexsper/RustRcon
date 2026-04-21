using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Global health multiplier applied to all NPCs; 1.0 = normal, 2.0 = double health; useful for difficulty scaling without modifying individual NPC prefabs</summary>
/// <remarks>Full RCON name: <c>ai.npchealthmultiplier</c></remarks>
public sealed class AiNpchealthmultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npchealthmultiplier";

    /// <summary>Reads the current value of <c>ai.npchealthmultiplier</c>.</summary>
    public static AiNpchealthmultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpchealthmultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npchealthmultiplier</c> to <paramref name="value"/>.</summary>
    public static AiNpchealthmultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpchealthmultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
