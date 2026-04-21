using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum milliseconds the dedicated write thread will block waiting to send data before timing out (clamped 1–1000)</summary>
/// <remarks>Full RCON name: <c>server.maxwritethreadwait</c></remarks>
public sealed class ServerMaxwritethreadwaitCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxwritethreadwait";

    /// <summary>Reads the current value of <c>server.maxwritethreadwait</c>.</summary>
    public static ServerMaxwritethreadwaitCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxwritethreadwaitCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxwritethreadwait</c> to <paramref name="value"/>.</summary>
    public static ServerMaxwritethreadwaitCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxwritethreadwaitCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
