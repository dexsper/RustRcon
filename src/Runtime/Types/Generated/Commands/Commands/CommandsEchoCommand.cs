using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>commands.echo</c>.</summary>
/// <remarks>Full RCON name: <c>commands.echo</c></remarks>
public sealed class CommandsEchoCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "commands.echo";

    /// <summary>Creates a new <see cref="CommandsEchoCommand"/> command.</summary>
    public static CommandsEchoCommand Create()
    {
        var cmd = CreatePackage<CommandsEchoCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
