using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>commands.find</c>.</summary>
/// <remarks>Full RCON name: <c>commands.find</c></remarks>
public sealed class CommandsFindCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "commands.find";

    /// <summary>Creates a new <see cref="CommandsFindCommand"/> command.</summary>
    public static CommandsFindCommand Create()
    {
        var cmd = CreatePackage<CommandsFindCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
