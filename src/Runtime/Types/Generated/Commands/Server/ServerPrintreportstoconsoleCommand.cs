using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Should F7 reports from players be printed to console</summary>
/// <remarks>Full RCON name: <c>server.printreportstoconsole</c></remarks>
public sealed class ServerPrintreportstoconsoleCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.printreportstoconsole";

    /// <summary>Reads the current value of <c>server.printreportstoconsole</c>.</summary>
    public static ServerPrintreportstoconsoleCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPrintreportstoconsoleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.printreportstoconsole</c> to <paramref name="value"/>.</summary>
    public static ServerPrintreportstoconsoleCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerPrintreportstoconsoleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
