using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Checks whether the named or Steam-ID-specified player is currently online on any server in the Nexus cluster</summary>
/// <remarks>Full RCON name: <c>nexus.playeronline</c></remarks>
public sealed class NexusPlayeronlineCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.playeronline";

    /// <summary>Creates a new <see cref="NexusPlayeronlineCommand"/> command.</summary>
    public static NexusPlayeronlineCommand Create(ulong uInt)
    {
        var cmd = CreatePackage<NexusPlayeronlineCommand>();
        cmd.Content = $"{CommandFullName} {uInt}";
        return cmd;
    }
}
