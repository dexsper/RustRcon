using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If npc_enable is set to false then npcs won't spawn. (default: true)</summary>
/// <remarks>Full RCON name: <c>ai.npc_enable</c></remarks>
public sealed class AiNpcEnableCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_enable";

    /// <summary>Reads the current value of <c>ai.npc_enable</c>.</summary>
    public static AiNpcEnableCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcEnableCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_enable</c> to <paramref name="value"/>.</summary>
    public static AiNpcEnableCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiNpcEnableCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
