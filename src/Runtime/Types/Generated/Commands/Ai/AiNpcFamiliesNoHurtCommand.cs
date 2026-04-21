using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If npc_families_no_hurt is true, npcs of the same family won't be able to hurt each other. (default: true)</summary>
/// <remarks>Full RCON name: <c>ai.npc_families_no_hurt</c></remarks>
public sealed class AiNpcFamiliesNoHurtCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_families_no_hurt";

    /// <summary>Reads the current value of <c>ai.npc_families_no_hurt</c>.</summary>
    public static AiNpcFamiliesNoHurtCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcFamiliesNoHurtCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_families_no_hurt</c> to <paramref name="value"/>.</summary>
    public static AiNpcFamiliesNoHurtCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiNpcFamiliesNoHurtCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
