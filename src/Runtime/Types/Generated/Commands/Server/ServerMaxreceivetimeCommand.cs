using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum milliseconds the network receive thread is allowed to run per frame; increase if players report missed packets on high-population servers (clamped 10–1000)</summary>
/// <remarks>Full RCON name: <c>server.maxreceivetime</c></remarks>
public sealed class ServerMaxreceivetimeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxreceivetime";

    /// <summary>Reads the current value of <c>server.maxreceivetime</c>.</summary>
    public static ServerMaxreceivetimeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxreceivetimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxreceivetime</c> to <paramref name="value"/>.</summary>
    public static ServerMaxreceivetimeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxreceivetimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
