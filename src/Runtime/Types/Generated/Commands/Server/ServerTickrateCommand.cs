using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of server simulation ticks per second; higher values improve responsiveness but increase CPU usage</summary>
/// <remarks>Full RCON name: <c>server.tickrate</c></remarks>
public sealed class ServerTickrateCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.tickrate";

    /// <summary>Reads the current value of <c>server.tickrate</c>.</summary>
    public static ServerTickrateCommand CreateGet()
    {
        var cmd = CreatePackage<ServerTickrateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.tickrate</c> to <paramref name="value"/>.</summary>
    public static ServerTickrateCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerTickrateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
