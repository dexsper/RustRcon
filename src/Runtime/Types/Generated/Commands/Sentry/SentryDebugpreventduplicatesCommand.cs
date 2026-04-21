using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Prevents auto turrets getting added more than once to the IO queue</summary>
/// <remarks>Full RCON name: <c>sentry.debugpreventduplicates</c></remarks>
public sealed class SentryDebugpreventduplicatesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "sentry.debugpreventduplicates";

    /// <summary>Reads the current value of <c>sentry.debugpreventduplicates</c>.</summary>
    public static SentryDebugpreventduplicatesCommand CreateGet()
    {
        var cmd = CreatePackage<SentryDebugpreventduplicatesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>sentry.debugpreventduplicates</c> to <paramref name="value"/>.</summary>
    public static SentryDebugpreventduplicatesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<SentryDebugpreventduplicatesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
