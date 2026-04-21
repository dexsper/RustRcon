using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum total byte size of the incoming read queue; excess bytes are dropped to prevent memory exhaustion from a flood of large packets</summary>
/// <remarks>Full RCON name: <c>server.maxreadqueuebytes</c></remarks>
public sealed class ServerMaxreadqueuebytesCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxreadqueuebytes";

    /// <summary>Reads the current value of <c>server.maxreadqueuebytes</c>.</summary>
    public static ServerMaxreadqueuebytesCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxreadqueuebytesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxreadqueuebytes</c> to <paramref name="value"/>.</summary>
    public static ServerMaxreadqueuebytesCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxreadqueuebytesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
