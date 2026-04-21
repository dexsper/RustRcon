using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Short description of the server shown to players in the server browser</summary>
/// <remarks>Full RCON name: <c>server.description</c></remarks>
public sealed class ServerDescriptionCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.description";

    /// <summary>Reads the current value of <c>server.description</c>.</summary>
    public static ServerDescriptionCommand CreateGet()
    {
        var cmd = CreatePackage<ServerDescriptionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.description</c> to <paramref name="value"/>.</summary>
    public static ServerDescriptionCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerDescriptionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
