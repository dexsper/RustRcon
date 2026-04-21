using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Print out currently connected clients</summary>
/// <remarks>Full RCON name: <c>global.status</c></remarks>
public sealed class GlobalStatusCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.status";

    /// <summary>Creates a new <see cref="GlobalStatusCommand"/> command.</summary>
    public static GlobalStatusCommand Create(string arg0, string arg1, bool json = false)
    {
        var cmd = CreatePackage<GlobalStatusCommand>();
        var content = new System.Text.StringBuilder(CommandFullName);
        content.Append($" {arg0}");
        content.Append($" {arg1}");
        if (json) content.Append(" --json");
        cmd.Content = content.ToString();
        return cmd;
    }
}
