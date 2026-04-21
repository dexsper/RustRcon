using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Minutes of inactivity before admin players are idle-kicked; 0 disables idle kick specifically for admins regardless of idlekickmode</summary>
/// <remarks>Full RCON name: <c>server.idlekickadmins</c></remarks>
public sealed class ServerIdlekickadminsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.idlekickadmins";

    /// <summary>Reads the current value of <c>server.idlekickadmins</c>.</summary>
    public static ServerIdlekickadminsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerIdlekickadminsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.idlekickadmins</c> to <paramref name="value"/>.</summary>
    public static ServerIdlekickadminsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerIdlekickadminsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
