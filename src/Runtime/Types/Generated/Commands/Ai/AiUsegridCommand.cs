using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, AI uses the spatial grid for entity queries; disable to fall back to brute-force entity iteration for debugging spatial query issues</summary>
/// <remarks>Full RCON name: <c>ai.usegrid</c></remarks>
public sealed class AiUsegridCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.usegrid";

    /// <summary>Reads the current value of <c>ai.usegrid</c>.</summary>
    public static AiUsegridCommand CreateGet()
    {
        var cmd = CreatePackage<AiUsegridCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.usegrid</c> to <paramref name="value"/>.</summary>
    public static AiUsegridCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiUsegridCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
