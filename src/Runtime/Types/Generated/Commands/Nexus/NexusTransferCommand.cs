using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Initiates a Nexus transfer of the specified player to a named destination server or zone in the cluster</summary>
/// <remarks>Full RCON name: <c>nexus.transfer</c></remarks>
public sealed class NexusTransferCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.transfer";

    /// <summary>Creates a new <see cref="NexusTransferCommand"/> command.</summary>
    public static NexusTransferCommand Create(string text)
    {
        var cmd = CreatePackage<NexusTransferCommand>();
        cmd.Content = $"{CommandFullName} {text}";
        return cmd;
    }
}
