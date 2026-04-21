using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How often (in hours) the water well NPC's update their sell orders</summary>
/// <remarks>Full RCON name: <c>server.waterwellnpcsalesrefreshfrequency</c></remarks>
public sealed class ServerWaterwellnpcsalesrefreshfrequencyCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.waterwellnpcsalesrefreshfrequency";

    /// <summary>Reads the current value of <c>server.waterwellnpcsalesrefreshfrequency</c>.</summary>
    public static ServerWaterwellnpcsalesrefreshfrequencyCommand CreateGet()
    {
        var cmd = CreatePackage<ServerWaterwellnpcsalesrefreshfrequencyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.waterwellnpcsalesrefreshfrequency</c> to <paramref name="value"/>.</summary>
    public static ServerWaterwellnpcsalesrefreshfrequencyCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerWaterwellnpcsalesrefreshfrequencyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
