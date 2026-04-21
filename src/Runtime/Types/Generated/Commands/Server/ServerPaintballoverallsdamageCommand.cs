using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much to scale paintball damage when both the hit player and initiator player have paintball overalls on (see paintballstandarddamage for scaling standard paintball damage)</summary>
/// <remarks>Full RCON name: <c>server.paintballoverallsdamage</c></remarks>
public sealed class ServerPaintballoverallsdamageCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.paintballoverallsdamage";

    /// <summary>Reads the current value of <c>server.paintballoverallsdamage</c>.</summary>
    public static ServerPaintballoverallsdamageCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPaintballoverallsdamageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.paintballoverallsdamage</c> to <paramref name="value"/>.</summary>
    public static ServerPaintballoverallsdamageCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerPaintballoverallsdamageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
