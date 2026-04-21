using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The angle under which the AI will think it's being aimed at at by a player</summary>
/// <remarks>Full RCON name: <c>ai.aimedatangle</c></remarks>
public sealed class AiAimedatangleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.aimedatangle";

    /// <summary>Reads the current value of <c>ai.aimedatangle</c>.</summary>
    public static AiAimedatangleCommand CreateGet()
    {
        var cmd = CreatePackage<AiAimedatangleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.aimedatangle</c> to <paramref name="value"/>.</summary>
    public static AiAimedatangleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiAimedatangleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
