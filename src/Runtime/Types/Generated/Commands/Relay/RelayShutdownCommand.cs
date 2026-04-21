using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Shutsdown the Rust Relay sever connection</summary>
/// <remarks>Full RCON name: <c>relay.shutdown</c></remarks>
public sealed class RelayShutdownCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relay.shutdown";

    /// <summary>Creates a new <see cref="RelayShutdownCommand"/> command.</summary>
    public static RelayShutdownCommand Create()
    {
        var cmd = CreatePackage<RelayShutdownCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
