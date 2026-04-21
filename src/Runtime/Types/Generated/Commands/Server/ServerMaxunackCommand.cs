using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of unacknowledged network messages per connection before the server starts applying backpressure to that client</summary>
/// <remarks>Full RCON name: <c>server.maxunack</c></remarks>
public sealed class ServerMaxunackCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxunack";

    /// <summary>Reads the current value of <c>server.maxunack</c>.</summary>
    public static ServerMaxunackCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxunackCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxunack</c> to <paramref name="value"/>.</summary>
    public static ServerMaxunackCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxunackCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
