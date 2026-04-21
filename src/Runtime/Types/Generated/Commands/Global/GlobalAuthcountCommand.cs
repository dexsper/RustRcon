using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Returns all entities that the provided player is authed to (TC's, locks, etc), supports --json</summary>
/// <remarks>Full RCON name: <c>global.authcount</c></remarks>
public sealed class GlobalAuthcountCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.authcount";

    /// <summary>Creates a new <see cref="GlobalAuthcountCommand"/> command.</summary>
    public static GlobalAuthcountCommand Create(ulong arg0, string text, bool json = false)
    {
        var cmd = CreatePackage<GlobalAuthcountCommand>();
        var content = new System.Text.StringBuilder(CommandFullName);
        content.Append($" {arg0}");
        content.Append($" {text}");
        if (json) content.Append(" --json");
        cmd.Content = content.ToString();
        return cmd;
    }
}
