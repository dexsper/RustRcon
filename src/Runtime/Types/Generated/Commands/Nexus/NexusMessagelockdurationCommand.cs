using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Time in seconds to allow the server to process nexus messages before re-sending (requires restart)</summary>
/// <remarks>Full RCON name: <c>nexus.messagelockduration</c></remarks>
public sealed class NexusMessagelockdurationCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.messagelockduration";

    /// <summary>Reads the current value of <c>nexus.messagelockduration</c>.</summary>
    public static NexusMessagelockdurationCommand CreateGet()
    {
        var cmd = CreatePackage<NexusMessagelockdurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>nexus.messagelockduration</c> to <paramref name="value"/>.</summary>
    public static NexusMessagelockdurationCommand CreateSet(int value)
    {
        var cmd = CreatePackage<NexusMessagelockdurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
