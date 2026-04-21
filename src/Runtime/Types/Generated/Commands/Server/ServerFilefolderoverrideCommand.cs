using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Override the root storage folder for server files; leave empty to use the default server/identity path</summary>
/// <remarks>Full RCON name: <c>server.filefolderoverride</c></remarks>
public sealed class ServerFilefolderoverrideCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.filefolderoverride";

    /// <summary>Reads the current value of <c>server.filefolderoverride</c>.</summary>
    public static ServerFilefolderoverrideCommand CreateGet()
    {
        var cmd = CreatePackage<ServerFilefolderoverrideCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.filefolderoverride</c> to <paramref name="value"/>.</summary>
    public static ServerFilefolderoverrideCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerFilefolderoverrideCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
