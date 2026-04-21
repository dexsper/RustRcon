using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) How often (in seconds) the server automatically saves the game world to disk; default is every 600 seconds (10 minutes)</summary>
/// <remarks>Full RCON name: <c>server.saveinterval</c></remarks>
public sealed class ServerSaveintervalCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.saveinterval";

    /// <summary>Reads the current value of <c>server.saveinterval</c>.</summary>
    public static ServerSaveintervalCommand CreateGet()
    {
        var cmd = CreatePackage<ServerSaveintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.saveinterval</c> to <paramref name="value"/>.</summary>
    public static ServerSaveintervalCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerSaveintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
