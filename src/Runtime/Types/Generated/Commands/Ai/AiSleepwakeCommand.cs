using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, AI information zones can sleep inactive NPCs and wake them when players approach; disable to keep all NPCs awake at all times</summary>
/// <remarks>Full RCON name: <c>ai.sleepwake</c></remarks>
public sealed class AiSleepwakeCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.sleepwake";

    /// <summary>Reads the current value of <c>ai.sleepwake</c>.</summary>
    public static AiSleepwakeCommand CreateGet()
    {
        var cmd = CreatePackage<AiSleepwakeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.sleepwake</c> to <paramref name="value"/>.</summary>
    public static AiSleepwakeCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiSleepwakeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
