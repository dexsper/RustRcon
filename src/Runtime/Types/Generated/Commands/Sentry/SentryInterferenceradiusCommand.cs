using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>radius to check for other turrets</summary>
/// <remarks>Full RCON name: <c>sentry.interferenceradius</c></remarks>
public sealed class SentryInterferenceradiusCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "sentry.interferenceradius";

    /// <summary>Reads the current value of <c>sentry.interferenceradius</c>.</summary>
    public static SentryInterferenceradiusCommand CreateGet()
    {
        var cmd = CreatePackage<SentryInterferenceradiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>sentry.interferenceradius</c> to <paramref name="value"/>.</summary>
    public static SentryInterferenceradiusCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SentryInterferenceradiusCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
