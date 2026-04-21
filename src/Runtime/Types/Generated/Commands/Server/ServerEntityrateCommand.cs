using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) How many times per second entity network state is sent to clients; higher values reduce perceived lag for moving objects</summary>
/// <remarks>Full RCON name: <c>server.entityrate</c></remarks>
public sealed class ServerEntityrateCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.entityrate";

    /// <summary>Reads the current value of <c>server.entityrate</c>.</summary>
    public static ServerEntityrateCommand CreateGet()
    {
        var cmd = CreatePackage<ServerEntityrateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.entityrate</c> to <paramref name="value"/>.</summary>
    public static ServerEntityrateCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerEntityrateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
