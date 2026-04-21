using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum milliseconds the decryption thread will block before timing out; increase if CPU-heavy encryption causes dropped packets (clamped 1–1000)</summary>
/// <remarks>Full RCON name: <c>server.maxdecryptthreadwait</c></remarks>
public sealed class ServerMaxdecryptthreadwaitCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxdecryptthreadwait";

    /// <summary>Reads the current value of <c>server.maxdecryptthreadwait</c>.</summary>
    public static ServerMaxdecryptthreadwaitCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxdecryptthreadwaitCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxdecryptthreadwait</c> to <paramref name="value"/>.</summary>
    public static ServerMaxdecryptthreadwaitCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxdecryptthreadwaitCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
