using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Time in seconds allocated to each entity batch update pass; the server will not start a new batch until this interval has elapsed</summary>
/// <remarks>Full RCON name: <c>server.entitybatchtime</c></remarks>
public sealed class ServerEntitybatchtimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.entitybatchtime";

    /// <summary>Reads the current value of <c>server.entitybatchtime</c>.</summary>
    public static ServerEntitybatchtimeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerEntitybatchtimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.entitybatchtime</c> to <paramref name="value"/>.</summary>
    public static ServerEntitybatchtimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerEntitybatchtimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
