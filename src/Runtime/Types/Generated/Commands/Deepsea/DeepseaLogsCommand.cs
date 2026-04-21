using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, outputs verbose deep sea system log messages (portal transitions, wipe events, entity moves) to the server log for debugging</summary>
/// <remarks>Full RCON name: <c>deepsea.logs</c></remarks>
public sealed class DeepseaLogsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.logs";

    /// <summary>Reads the current value of <c>deepsea.logs</c>.</summary>
    public static DeepseaLogsCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaLogsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.logs</c> to <paramref name="value"/>.</summary>
    public static DeepseaLogsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DeepseaLogsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
