using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Player Update parallelism mode: 0-3, Higher modes are faster but more experimental. 2 by default</summary>
/// <remarks>Full RCON name: <c>server.useplayerupdatejobs</c></remarks>
public sealed class ServerUseplayerupdatejobsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.useplayerupdatejobs";

    /// <summary>Reads the current value of <c>server.useplayerupdatejobs</c>.</summary>
    public static ServerUseplayerupdatejobsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerUseplayerupdatejobsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.useplayerupdatejobs</c> to <paramref name="value"/>.</summary>
    public static ServerUseplayerupdatejobsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerUseplayerupdatejobsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
