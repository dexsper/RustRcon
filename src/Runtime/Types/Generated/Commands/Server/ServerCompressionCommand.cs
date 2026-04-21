using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables or disables network packet compression on the server; compression reduces bandwidth at the cost of a small amount of CPU time</summary>
/// <remarks>Full RCON name: <c>server.compression</c></remarks>
public sealed class ServerCompressionCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.compression";

    /// <summary>Reads the current value of <c>server.compression</c>.</summary>
    public static ServerCompressionCommand CreateGet()
    {
        var cmd = CreatePackage<ServerCompressionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.compression</c> to <paramref name="value"/>.</summary>
    public static ServerCompressionCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerCompressionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
