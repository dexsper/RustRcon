using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>server.cinematic</c>.</summary>
/// <remarks>Full RCON name: <c>server.cinematic</c></remarks>
public sealed class ServerCinematicCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.cinematic";

    /// <summary>Reads the current value of <c>server.cinematic</c>.</summary>
    public static ServerCinematicCommand CreateGet()
    {
        var cmd = CreatePackage<ServerCinematicCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.cinematic</c> to <paramref name="value"/>.</summary>
    public static ServerCinematicCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerCinematicCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
