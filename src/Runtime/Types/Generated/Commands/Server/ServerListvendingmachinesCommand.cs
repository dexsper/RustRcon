using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Prints all the vending machines on the server</summary>
/// <remarks>Full RCON name: <c>server.listvendingmachines</c></remarks>
public sealed class ServerListvendingmachinesCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.listvendingmachines";

    /// <summary>Creates a new <see cref="ServerListvendingmachinesCommand"/> command.</summary>
    public static ServerListvendingmachinesCommand Create(bool json = false)
    {
        var cmd = CreatePackage<ServerListvendingmachinesCommand>();
        var content = new System.Text.StringBuilder(CommandFullName);
        if (json) content.Append(" --json");
        cmd.Content = content.ToString();
        return cmd;
    }
}
