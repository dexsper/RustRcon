using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>max interference from other turrets</summary>
/// <remarks>Full RCON name: <c>sentry.maxinterference</c></remarks>
public sealed class SentryMaxinterferenceCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "sentry.maxinterference";

    /// <summary>Reads the current value of <c>sentry.maxinterference</c>.</summary>
    public static SentryMaxinterferenceCommand CreateGet()
    {
        var cmd = CreatePackage<SentryMaxinterferenceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>sentry.maxinterference</c> to <paramref name="value"/>.</summary>
    public static SentryMaxinterferenceCommand CreateSet(int value)
    {
        var cmd = CreatePackage<SentryMaxinterferenceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
