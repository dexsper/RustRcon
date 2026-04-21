using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>server.artificialtemperaturegrowablerange</c>.</summary>
/// <remarks>Full RCON name: <c>server.artificialtemperaturegrowablerange</c></remarks>
public sealed class ServerArtificialtemperaturegrowablerangeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.artificialtemperaturegrowablerange";

    /// <summary>Reads the current value of <c>server.artificialtemperaturegrowablerange</c>.</summary>
    public static ServerArtificialtemperaturegrowablerangeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerArtificialtemperaturegrowablerangeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.artificialtemperaturegrowablerange</c> to <paramref name="value"/>.</summary>
    public static ServerArtificialtemperaturegrowablerangeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerArtificialtemperaturegrowablerangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
