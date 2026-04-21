using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Custom cron expression for the wipe schedule. Overrides all other convars (except wipeUnixTimestampOverride) if set. Uses Cronos as a parser: https://github.com/HangfireIO/Cronos/</summary>
/// <remarks>Full RCON name: <c>wipetimer.wipecronoverride</c></remarks>
public sealed class WipetimerWipecronoverrideCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "wipetimer.wipecronoverride";

    /// <summary>Reads the current value of <c>wipetimer.wipecronoverride</c>.</summary>
    public static WipetimerWipecronoverrideCommand CreateGet()
    {
        var cmd = CreatePackage<WipetimerWipecronoverrideCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>wipetimer.wipecronoverride</c> to <paramref name="value"/>.</summary>
    public static WipetimerWipecronoverrideCommand CreateSet(string value)
    {
        var cmd = CreatePackage<WipetimerWipecronoverrideCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
