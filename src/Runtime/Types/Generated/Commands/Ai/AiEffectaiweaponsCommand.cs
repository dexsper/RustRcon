using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, AI weapons deal real damage when fired; disable to make NPC weapons harmless for testing AI behaviour safely</summary>
/// <remarks>Full RCON name: <c>ai.effectaiweapons</c></remarks>
public sealed class AiEffectaiweaponsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.effectaiweapons";

    /// <summary>Reads the current value of <c>ai.effectaiweapons</c>.</summary>
    public static AiEffectaiweaponsCommand CreateGet()
    {
        var cmd = CreatePackage<AiEffectaiweaponsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.effectaiweapons</c> to <paramref name="value"/>.</summary>
    public static AiEffectaiweaponsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiEffectaiweaponsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
