using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Get information about all the cars in the world</summary>
/// <remarks>Full RCON name: <c>global.carstats</c></remarks>
public sealed class GlobalCarstatsCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.carstats";

    /// <summary>Creates a new <see cref="GlobalCarstatsCommand"/> command.</summary>
    public static GlobalCarstatsCommand Create()
    {
        var cmd = CreatePackage<GlobalCarstatsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
