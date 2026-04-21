using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Server branch tag used by the server browser to identify modded or experimental variants; leave empty for vanilla</summary>
/// <remarks>Full RCON name: <c>server.branch</c></remarks>
public sealed class ServerBranchCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.branch";

    /// <summary>Reads the current value of <c>server.branch</c>.</summary>
    public static ServerBranchCommand CreateGet()
    {
        var cmd = CreatePackage<ServerBranchCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.branch</c> to <paramref name="value"/>.</summary>
    public static ServerBranchCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerBranchCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
