using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum milliseconds the dedicated read thread will block waiting for incoming data before timing out (clamped 1–1000)</summary>
/// <remarks>Full RCON name: <c>server.maxreadthreadwait</c></remarks>
public sealed class ServerMaxreadthreadwaitCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxreadthreadwait";

    /// <summary>Reads the current value of <c>server.maxreadthreadwait</c>.</summary>
    public static ServerMaxreadthreadwaitCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxreadthreadwaitCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxreadthreadwait</c> to <paramref name="value"/>.</summary>
    public static ServerMaxreadthreadwaitCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxreadthreadwaitCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
