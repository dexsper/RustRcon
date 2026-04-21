using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables automatic backups of server statistics data</summary>
/// <remarks>Full RCON name: <c>server.statbackup</c></remarks>
public sealed class ServerStatbackupCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.statbackup";

    /// <summary>Reads the current value of <c>server.statbackup</c>.</summary>
    public static ServerStatbackupCommand CreateGet()
    {
        var cmd = CreatePackage<ServerStatbackupCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.statbackup</c> to <paramref name="value"/>.</summary>
    public static ServerStatbackupCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerStatbackupCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
