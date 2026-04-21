using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>URL endpoint to use for the Nexus API</summary>
/// <remarks>Full RCON name: <c>nexus.endpoint</c></remarks>
public sealed class NexusEndpointCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.endpoint";

    /// <summary>Reads the current value of <c>nexus.endpoint</c>.</summary>
    public static NexusEndpointCommand CreateGet()
    {
        var cmd = CreatePackage<NexusEndpointCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>nexus.endpoint</c> to <paramref name="value"/>.</summary>
    public static NexusEndpointCommand CreateSet(string value)
    {
        var cmd = CreatePackage<NexusEndpointCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
