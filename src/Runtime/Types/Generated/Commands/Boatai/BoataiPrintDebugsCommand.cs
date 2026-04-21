using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, logs verbose boat AI decision-making output to the server console each AI tick</summary>
/// <remarks>Full RCON name: <c>boatai.print_debugs</c></remarks>
public sealed class BoataiPrintDebugsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatai.print_debugs";

    /// <summary>Reads the current value of <c>boatai.print_debugs</c>.</summary>
    public static BoataiPrintDebugsCommand CreateGet()
    {
        var cmd = CreatePackage<BoataiPrintDebugsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatai.print_debugs</c> to <paramref name="value"/>.</summary>
    public static BoataiPrintDebugsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BoataiPrintDebugsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
