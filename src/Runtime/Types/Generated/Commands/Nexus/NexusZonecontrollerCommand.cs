using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Name of the zone controller implementation used for this Nexus server (e.g. basic, advanced); controls how players are routed between servers</summary>
/// <remarks>Full RCON name: <c>nexus.zonecontroller</c></remarks>
public sealed class NexusZonecontrollerCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.zonecontroller";

    /// <summary>Reads the current value of <c>nexus.zonecontroller</c>.</summary>
    public static NexusZonecontrollerCommand CreateGet()
    {
        var cmd = CreatePackage<NexusZonecontrollerCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>nexus.zonecontroller</c> to <paramref name="value"/>.</summary>
    public static NexusZonecontrollerCommand CreateSet(string value)
    {
        var cmd = CreatePackage<NexusZonecontrollerCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
