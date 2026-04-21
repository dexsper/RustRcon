using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>analytics.log</c>.</summary>
/// <remarks>Full RCON name: <c>analytics.log</c></remarks>
public sealed class AnalyticsLogCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.log";

    /// <summary>Reads the current value of <c>analytics.log</c>.</summary>
    public static AnalyticsLogCommand CreateGet()
    {
        var cmd = CreatePackage<AnalyticsLogCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>analytics.log</c> to <paramref name="value"/>.</summary>
    public static AnalyticsLogCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AnalyticsLogCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
