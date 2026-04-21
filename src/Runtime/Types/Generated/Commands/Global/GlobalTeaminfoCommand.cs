using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a table of all members in the team of the specified player showing Steam ID, username, online status, and whether they are team leader; supports --json</summary>
/// <remarks>Full RCON name: <c>global.teaminfo</c></remarks>
public sealed class GlobalTeaminfoCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.teaminfo";

    /// <summary>Creates a new <see cref="GlobalTeaminfoCommand"/> command.</summary>
    public static GlobalTeaminfoCommand Create(ulong value, bool json = false)
    {
        var cmd = CreatePackage<GlobalTeaminfoCommand>();
        var content = new System.Text.StringBuilder(CommandFullName);
        content.Append($" {value}");
        if (json) content.Append(" --json");
        cmd.Content = content.ToString();
        return cmd;
    }
}
