using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Timeout (in seconds) for centralized banning web server requests</summary>
/// <remarks>Full RCON name: <c>server.bansservertimeout</c></remarks>
public sealed class ServerBansservertimeoutCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.bansservertimeout";

    /// <summary>Reads the current value of <c>server.bansservertimeout</c>.</summary>
    public static ServerBansservertimeoutCommand CreateGet()
    {
        var cmd = CreatePackage<ServerBansservertimeoutCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.bansservertimeout</c> to <paramref name="value"/>.</summary>
    public static ServerBansservertimeoutCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerBansservertimeoutCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
