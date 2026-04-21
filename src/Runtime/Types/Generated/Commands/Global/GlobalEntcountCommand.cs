using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Returns all entities that the provided player has placed, supports --json</summary>
/// <remarks>Full RCON name: <c>global.entcount</c></remarks>
public sealed class GlobalEntcountCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.entcount";

    /// <summary>Creates a new <see cref="GlobalEntcountCommand"/> command.</summary>
    public static GlobalEntcountCommand Create(ulong arg0, string text, bool json = false)
    {
        var cmd = CreatePackage<GlobalEntcountCommand>();
        var content = new System.Text.StringBuilder(CommandFullName);
        content.Append($" {arg0}");
        content.Append($" {text}");
        if (json) content.Append(" --json");
        cmd.Content = content.ToString();
        return cmd;
    }
}
