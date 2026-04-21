using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Kicks all currently connected players from the server with an optional reason; useful for forcing a restart or clearing the server</summary>
/// <remarks>Full RCON name: <c>global.kickall</c></remarks>
public sealed class GlobalKickallCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.kickall";

    /// <summary>Creates a new <see cref="GlobalKickallCommand"/> command.</summary>
    public static GlobalKickallCommand Create(string args)
    {
        var cmd = CreatePackage<GlobalKickallCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
