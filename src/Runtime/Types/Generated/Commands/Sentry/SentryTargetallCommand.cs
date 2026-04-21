using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>target everyone regardless of authorization</summary>
/// <remarks>Full RCON name: <c>sentry.targetall</c></remarks>
public sealed class SentryTargetallCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "sentry.targetall";

    /// <summary>Reads the current value of <c>sentry.targetall</c>.</summary>
    public static SentryTargetallCommand CreateGet()
    {
        var cmd = CreatePackage<SentryTargetallCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>sentry.targetall</c> to <paramref name="value"/>.</summary>
    public static SentryTargetallCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<SentryTargetallCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
