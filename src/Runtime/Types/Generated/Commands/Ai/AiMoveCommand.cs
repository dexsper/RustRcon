using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, AI entities move toward their NavMesh destinations; disable to freeze NPC movement while keeping brain logic running</summary>
/// <remarks>Full RCON name: <c>ai.move</c></remarks>
public sealed class AiMoveCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.move";

    /// <summary>Reads the current value of <c>ai.move</c>.</summary>
    public static AiMoveCommand CreateGet()
    {
        var cmd = CreatePackage<AiMoveCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.move</c> to <paramref name="value"/>.</summary>
    public static AiMoveCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiMoveCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
