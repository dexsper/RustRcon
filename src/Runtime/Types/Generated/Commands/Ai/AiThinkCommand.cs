using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, AI entities run their brain Think() logic each tick; disable to freeze all AI decision-making while leaving entities in place</summary>
/// <remarks>Full RCON name: <c>ai.think</c></remarks>
public sealed class AiThinkCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.think";

    /// <summary>Reads the current value of <c>ai.think</c>.</summary>
    public static AiThinkCommand CreateGet()
    {
        var cmd = CreatePackage<AiThinkCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.think</c> to <paramref name="value"/>.</summary>
    public static AiThinkCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiThinkCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
