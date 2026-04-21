using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Clears the relay send queue (useful if things are going wrong with the relay server)</summary>
/// <remarks>Full RCON name: <c>relay.clear_queue</c></remarks>
public sealed class RelayClearQueueCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relay.clear_queue";

    /// <summary>Creates a new <see cref="RelayClearQueueCommand"/> command.</summary>
    public static RelayClearQueueCommand Create()
    {
        var cmd = CreatePackage<RelayClearQueueCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
