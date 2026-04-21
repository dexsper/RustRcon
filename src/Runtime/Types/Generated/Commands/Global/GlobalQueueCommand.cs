using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the current state of server-side stability check and surroundings update queues; reports nothing useful on client</summary>
/// <remarks>Full RCON name: <c>global.queue</c></remarks>
public sealed class GlobalQueueCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.queue";

    /// <summary>Creates a new <see cref="GlobalQueueCommand"/> command.</summary>
    public static GlobalQueueCommand Create()
    {
        var cmd = CreatePackage<GlobalQueueCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
