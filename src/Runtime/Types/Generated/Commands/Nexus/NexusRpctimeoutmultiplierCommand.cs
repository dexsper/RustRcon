using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Multiplier for nexus RPC timeout durations in case we expect different latencies</summary>
/// <remarks>Full RCON name: <c>nexus.rpctimeoutmultiplier</c></remarks>
public sealed class NexusRpctimeoutmultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.rpctimeoutmultiplier";

    /// <summary>Reads the current value of <c>nexus.rpctimeoutmultiplier</c>.</summary>
    public static NexusRpctimeoutmultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<NexusRpctimeoutmultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>nexus.rpctimeoutmultiplier</c> to <paramref name="value"/>.</summary>
    public static NexusRpctimeoutmultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NexusRpctimeoutmultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
