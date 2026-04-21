using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the current state of all IO entity processing queues showing queue type and pending entity counts; admin-only</summary>
/// <remarks>Full RCON name: <c>ioentity.debugqueue</c></remarks>
public sealed class IoentityDebugqueueCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ioentity.debugqueue";

    /// <summary>Creates a new <see cref="IoentityDebugqueueCommand"/> command.</summary>
    public static IoentityDebugqueueCommand Create()
    {
        var cmd = CreatePackage<IoentityDebugqueueCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
