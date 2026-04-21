using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If true, RCON commands will be printed in the console</summary>
/// <remarks>Full RCON name: <c>rcon.print</c></remarks>
public sealed class RconPrintCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.print";

    /// <summary>Reads the current value of <c>rcon.print</c>.</summary>
    public static RconPrintCommand CreateGet()
    {
        var cmd = CreatePackage<RconPrintCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>rcon.print</c> to <paramref name="value"/>.</summary>
    public static RconPrintCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<RconPrintCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
