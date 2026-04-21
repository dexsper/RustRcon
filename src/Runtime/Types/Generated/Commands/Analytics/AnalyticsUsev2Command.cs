using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>analytics.usev2</c>.</summary>
/// <remarks>Full RCON name: <c>analytics.usev2</c></remarks>
public sealed class AnalyticsUsev2Command : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.usev2";

    /// <summary>Reads the current value of <c>analytics.usev2</c>.</summary>
    public static AnalyticsUsev2Command CreateGet()
    {
        var cmd = CreatePackage<AnalyticsUsev2Command>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>analytics.usev2</c> to <paramref name="value"/>.</summary>
    public static AnalyticsUsev2Command CreateSet(bool value)
    {
        var cmd = CreatePackage<AnalyticsUsev2Command>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
