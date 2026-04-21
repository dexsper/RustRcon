using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Maximum duration in seconds to batch clan chat messages to send to other servers on the nexus</summary>
/// <remarks>Full RCON name: <c>nexus.clanclatbatchduration</c></remarks>
public sealed class NexusClanclatbatchdurationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.clanclatbatchduration";

    /// <summary>Reads the current value of <c>nexus.clanclatbatchduration</c>.</summary>
    public static NexusClanclatbatchdurationCommand CreateGet()
    {
        var cmd = CreatePackage<NexusClanclatbatchdurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>nexus.clanclatbatchduration</c> to <paramref name="value"/>.</summary>
    public static NexusClanclatbatchdurationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NexusClanclatbatchdurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
