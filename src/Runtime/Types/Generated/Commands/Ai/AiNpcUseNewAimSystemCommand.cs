using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If npc_use_new_aim_system is true, npcs will miss on purpose on occasion, where the old system would randomize aim cone. (default: true)</summary>
/// <remarks>Full RCON name: <c>ai.npc_use_new_aim_system</c></remarks>
public sealed class AiNpcUseNewAimSystemCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_use_new_aim_system";

    /// <summary>Reads the current value of <c>ai.npc_use_new_aim_system</c>.</summary>
    public static AiNpcUseNewAimSystemCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcUseNewAimSystemCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_use_new_aim_system</c> to <paramref name="value"/>.</summary>
    public static AiNpcUseNewAimSystemCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiNpcUseNewAimSystemCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
