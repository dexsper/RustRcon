using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of encrypted packets that can wait in the decryption queue before being dropped</summary>
/// <remarks>Full RCON name: <c>server.maxdecryptqueuelength</c></remarks>
public sealed class ServerMaxdecryptqueuelengthCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxdecryptqueuelength";

    /// <summary>Reads the current value of <c>server.maxdecryptqueuelength</c>.</summary>
    public static ServerMaxdecryptqueuelengthCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxdecryptqueuelengthCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxdecryptqueuelength</c> to <paramref name="value"/>.</summary>
    public static ServerMaxdecryptqueuelengthCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxdecryptqueuelengthCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
