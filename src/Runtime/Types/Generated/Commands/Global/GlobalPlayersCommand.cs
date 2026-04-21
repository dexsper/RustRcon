using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Print out currently connected clients etc</summary>
/// <remarks>Full RCON name: <c>global.players</c></remarks>
public sealed class GlobalPlayersCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.players";

    /// <summary>Creates a new <see cref="GlobalPlayersCommand"/> command.</summary>
    public static GlobalPlayersCommand Create(bool json = false)
    {
        var cmd = CreatePackage<GlobalPlayersCommand>();
        var content = new System.Text.StringBuilder(CommandFullName);
        if (json) content.Append(" --json");
        cmd.Content = content.ToString();
        return cmd;
    }
}
