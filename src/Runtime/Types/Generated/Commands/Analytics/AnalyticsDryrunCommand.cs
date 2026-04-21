using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Executes entire flow without actually sending out anything</summary>
/// <remarks>Full RCON name: <c>analytics.dryrun</c></remarks>
public sealed class AnalyticsDryrunCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.dryrun";

    /// <summary>Reads the current value of <c>analytics.dryrun</c>.</summary>
    public static AnalyticsDryrunCommand CreateGet()
    {
        var cmd = CreatePackage<AnalyticsDryrunCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>analytics.dryrun</c> to <paramref name="value"/>.</summary>
    public static AnalyticsDryrunCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AnalyticsDryrunCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
