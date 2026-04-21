using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables low-level network activity logging on the server; produces verbose output useful for diagnosing connection and packet issues</summary>
/// <remarks>Full RCON name: <c>server.netlog</c></remarks>
public sealed class ServerNetlogCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.netlog";

    /// <summary>Reads the current value of <c>server.netlog</c>.</summary>
    public static ServerNetlogCommand CreateGet()
    {
        var cmd = CreatePackage<ServerNetlogCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.netlog</c> to <paramref name="value"/>.</summary>
    public static ServerNetlogCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerNetlogCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
