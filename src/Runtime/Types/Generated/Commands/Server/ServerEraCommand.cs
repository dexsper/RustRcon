using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>none,primitive,medieval,frontier,rust</summary>
/// <remarks>Full RCON name: <c>server.era</c></remarks>
public sealed class ServerEraCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.era";

    /// <summary>Reads the current value of <c>server.era</c>.</summary>
    public static ServerEraCommand CreateGet()
    {
        var cmd = CreatePackage<ServerEraCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.era</c> to <paramref name="value"/>.</summary>
    public static ServerEraCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerEraCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
