using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>server.sprinklerradius</c>.</summary>
/// <remarks>Full RCON name: <c>server.sprinklerradius</c></remarks>
public sealed class ServerSprinklerradiusCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.sprinklerradius";

    /// <summary>Reads the current value of <c>server.sprinklerradius</c>.</summary>
    public static ServerSprinklerradiusCommand CreateGet()
    {
        var cmd = CreatePackage<ServerSprinklerradiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.sprinklerradius</c> to <paramref name="value"/>.</summary>
    public static ServerSprinklerradiusCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerSprinklerradiusCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
