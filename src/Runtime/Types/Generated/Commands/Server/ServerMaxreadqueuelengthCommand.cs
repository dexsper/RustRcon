using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of packets that can be queued in the incoming read queue; excess packets are dropped to prevent memory exhaustion</summary>
/// <remarks>Full RCON name: <c>server.maxreadqueuelength</c></remarks>
public sealed class ServerMaxreadqueuelengthCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxreadqueuelength";

    /// <summary>Reads the current value of <c>server.maxreadqueuelength</c>.</summary>
    public static ServerMaxreadqueuelengthCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxreadqueuelengthCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxreadqueuelength</c> to <paramref name="value"/>.</summary>
    public static ServerMaxreadqueuelengthCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxreadqueuelengthCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
