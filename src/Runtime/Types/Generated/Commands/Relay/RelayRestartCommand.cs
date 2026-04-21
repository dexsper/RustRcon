using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Attempts to restart the Rust Relay connection (may cause short lag)</summary>
/// <remarks>Full RCON name: <c>relay.restart</c></remarks>
public sealed class RelayRestartCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relay.restart";

    /// <summary>Creates a new <see cref="RelayRestartCommand"/> command.</summary>
    public static RelayRestartCommand Create()
    {
        var cmd = CreatePackage<RelayRestartCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
