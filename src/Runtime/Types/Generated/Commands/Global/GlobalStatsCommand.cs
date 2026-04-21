using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Print out stats of currently connected clients</summary>
/// <remarks>Full RCON name: <c>global.stats</c></remarks>
public sealed class GlobalStatsCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.stats";

    /// <summary>Creates a new <see cref="GlobalStatsCommand"/> command.</summary>
    public static GlobalStatsCommand Create(ulong uInt, bool json = false)
    {
        var cmd = CreatePackage<GlobalStatsCommand>();
        var content = new System.Text.StringBuilder(CommandFullName);
        content.Append($" {uInt}");
        if (json) content.Append(" --json");
        cmd.Content = content.ToString();
        return cmd;
    }
}
