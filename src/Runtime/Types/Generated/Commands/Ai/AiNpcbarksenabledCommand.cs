using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>ai.npcbarksenabled</c>.</summary>
/// <remarks>Full RCON name: <c>ai.npcbarksenabled</c></remarks>
public sealed class AiNpcbarksenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npcbarksenabled";

    /// <summary>Reads the current value of <c>ai.npcbarksenabled</c>.</summary>
    public static AiNpcbarksenabledCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcbarksenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npcbarksenabled</c> to <paramref name="value"/>.</summary>
    public static AiNpcbarksenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiNpcbarksenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
