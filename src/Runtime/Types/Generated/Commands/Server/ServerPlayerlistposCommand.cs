using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Prints the position of all players on the server</summary>
/// <remarks>Full RCON name: <c>server.playerlistpos</c></remarks>
public sealed class ServerPlayerlistposCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.playerlistpos";

    /// <summary>Creates a new <see cref="ServerPlayerlistposCommand"/> command.</summary>
    public static ServerPlayerlistposCommand Create(bool json = false)
    {
        var cmd = CreatePackage<ServerPlayerlistposCommand>();
        var content = new System.Text.StringBuilder(CommandFullName);
        if (json) content.Append(" --json");
        cmd.Content = content.ToString();
        return cmd;
    }
}
