using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, logs AI-related warnings and issues to the server console; useful for diagnosing pathfinding and brain errors</summary>
/// <remarks>Full RCON name: <c>ai.logissues</c></remarks>
public sealed class AiLogissuesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.logissues";

    /// <summary>Reads the current value of <c>ai.logissues</c>.</summary>
    public static AiLogissuesCommand CreateGet()
    {
        var cmd = CreatePackage<AiLogissuesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.logissues</c> to <paramref name="value"/>.</summary>
    public static AiLogissuesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiLogissuesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
