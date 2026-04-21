using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The angle under which the AI will think it's being watched by another entity</summary>
/// <remarks>Full RCON name: <c>ai.watchedangle</c></remarks>
public sealed class AiWatchedangleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.watchedangle";

    /// <summary>Reads the current value of <c>ai.watchedangle</c>.</summary>
    public static AiWatchedangleCommand CreateGet()
    {
        var cmd = CreatePackage<AiWatchedangleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.watchedangle</c> to <paramref name="value"/>.</summary>
    public static AiWatchedangleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiWatchedangleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
