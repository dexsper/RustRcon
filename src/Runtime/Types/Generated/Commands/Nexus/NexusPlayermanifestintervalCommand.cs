using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Interval in seconds to broadcast the player manifest to other servers on the nexus</summary>
/// <remarks>Full RCON name: <c>nexus.playermanifestinterval</c></remarks>
public sealed class NexusPlayermanifestintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.playermanifestinterval";

    /// <summary>Reads the current value of <c>nexus.playermanifestinterval</c>.</summary>
    public static NexusPlayermanifestintervalCommand CreateGet()
    {
        var cmd = CreatePackage<NexusPlayermanifestintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>nexus.playermanifestinterval</c> to <paramref name="value"/>.</summary>
    public static NexusPlayermanifestintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NexusPlayermanifestintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
