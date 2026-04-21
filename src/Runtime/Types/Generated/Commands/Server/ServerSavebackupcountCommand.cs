using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of rolling save-file backups to keep; each autosave rotates the oldest backup out</summary>
/// <remarks>Full RCON name: <c>server.savebackupcount</c></remarks>
public sealed class ServerSavebackupcountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.savebackupcount";

    /// <summary>Reads the current value of <c>server.savebackupcount</c>.</summary>
    public static ServerSavebackupcountCommand CreateGet()
    {
        var cmd = CreatePackage<ServerSavebackupcountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.savebackupcount</c> to <paramref name="value"/>.</summary>
    public static ServerSavebackupcountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerSavebackupcountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
