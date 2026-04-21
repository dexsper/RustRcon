using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.reporting</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.reporting</c></remarks>
public sealed class AntihackReportingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.reporting";

    /// <summary>Reads the current value of <c>antihack.reporting</c>.</summary>
    public static AntihackReportingCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackReportingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.reporting</c> to <paramref name="value"/>.</summary>
    public static AntihackReportingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackReportingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
