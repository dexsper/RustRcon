using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_max_junkpile_count define how many npcs can spawn into the world at junkpiles at the same time (does not include monuments) (Default: 30)</summary>
/// <remarks>Full RCON name: <c>ai.npc_max_junkpile_count</c></remarks>
public sealed class AiNpcMaxJunkpileCountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_max_junkpile_count";

    /// <summary>Reads the current value of <c>ai.npc_max_junkpile_count</c>.</summary>
    public static AiNpcMaxJunkpileCountCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcMaxJunkpileCountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_max_junkpile_count</c> to <paramref name="value"/>.</summary>
    public static AiNpcMaxJunkpileCountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AiNpcMaxJunkpileCountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
