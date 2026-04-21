using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>how long until something is considered hostile after it attacked</summary>
/// <remarks>Full RCON name: <c>sentry.hostileduration</c></remarks>
public sealed class SentryHostiledurationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "sentry.hostileduration";

    /// <summary>Reads the current value of <c>sentry.hostileduration</c>.</summary>
    public static SentryHostiledurationCommand CreateGet()
    {
        var cmd = CreatePackage<SentryHostiledurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>sentry.hostileduration</c> to <paramref name="value"/>.</summary>
    public static SentryHostiledurationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SentryHostiledurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
