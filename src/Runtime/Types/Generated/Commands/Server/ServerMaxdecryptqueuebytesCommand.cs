using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum total byte size of packets waiting for decryption; excess packets are dropped when the limit is reached</summary>
/// <remarks>Full RCON name: <c>server.maxdecryptqueuebytes</c></remarks>
public sealed class ServerMaxdecryptqueuebytesCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxdecryptqueuebytes";

    /// <summary>Reads the current value of <c>server.maxdecryptqueuebytes</c>.</summary>
    public static ServerMaxdecryptqueuebytesCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxdecryptqueuebytesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxdecryptqueuebytes</c> to <paramref name="value"/>.</summary>
    public static ServerMaxdecryptqueuebytesCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxdecryptqueuebytesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
