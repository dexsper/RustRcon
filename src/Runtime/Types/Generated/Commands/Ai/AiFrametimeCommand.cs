using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Target frame time budget in seconds for AI tick processing; default is 5s in production (1s in editor) to cap CPU usage per AI frame</summary>
/// <remarks>Full RCON name: <c>ai.frametime</c></remarks>
public sealed class AiFrametimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.frametime";

    /// <summary>Reads the current value of <c>ai.frametime</c>.</summary>
    public static AiFrametimeCommand CreateGet()
    {
        var cmd = CreatePackage<AiFrametimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.frametime</c> to <paramref name="value"/>.</summary>
    public static AiFrametimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiFrametimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
