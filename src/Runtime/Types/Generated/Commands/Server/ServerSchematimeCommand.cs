using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) How often (in seconds) the full entity schema is re-broadcast to all clients; default is every 1800 seconds</summary>
/// <remarks>Full RCON name: <c>server.schematime</c></remarks>
public sealed class ServerSchematimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.schematime";

    /// <summary>Reads the current value of <c>server.schematime</c>.</summary>
    public static ServerSchematimeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerSchematimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.schematime</c> to <paramref name="value"/>.</summary>
    public static ServerSchematimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerSchematimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
