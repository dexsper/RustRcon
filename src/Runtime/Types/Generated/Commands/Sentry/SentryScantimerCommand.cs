using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How quickly can a turret acquire a potential target. Less is faster, but perf taxing</summary>
/// <remarks>Full RCON name: <c>sentry.scantimer</c></remarks>
public sealed class SentryScantimerCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "sentry.scantimer";

    /// <summary>Reads the current value of <c>sentry.scantimer</c>.</summary>
    public static SentryScantimerCommand CreateGet()
    {
        var cmd = CreatePackage<SentryScantimerCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>sentry.scantimer</c> to <paramref name="value"/>.</summary>
    public static SentryScantimerCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SentryScantimerCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
