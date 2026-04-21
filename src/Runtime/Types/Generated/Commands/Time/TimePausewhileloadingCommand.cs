using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>time.pausewhileloading</c>.</summary>
/// <remarks>Full RCON name: <c>time.pausewhileloading</c></remarks>
public sealed class TimePausewhileloadingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "time.pausewhileloading";

    /// <summary>Reads the current value of <c>time.pausewhileloading</c>.</summary>
    public static TimePausewhileloadingCommand CreateGet()
    {
        var cmd = CreatePackage<TimePausewhileloadingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>time.pausewhileloading</c> to <paramref name="value"/>.</summary>
    public static TimePausewhileloadingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<TimePausewhileloadingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
