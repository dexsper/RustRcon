using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If npc_ignore_chairs is true, npcs won't care about seeking out and sitting in chairs. (default: true)</summary>
/// <remarks>Full RCON name: <c>ai.npc_ignore_chairs</c></remarks>
public sealed class AiNpcIgnoreChairsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_ignore_chairs";

    /// <summary>Reads the current value of <c>ai.npc_ignore_chairs</c>.</summary>
    public static AiNpcIgnoreChairsCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcIgnoreChairsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_ignore_chairs</c> to <paramref name="value"/>.</summary>
    public static AiNpcIgnoreChairsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiNpcIgnoreChairsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
