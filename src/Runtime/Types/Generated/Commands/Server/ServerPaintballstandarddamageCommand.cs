using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much to scale standard paintball damage (see paintballoverallsdamage for scaling damage for when players have overalls on)</summary>
/// <remarks>Full RCON name: <c>server.paintballstandarddamage</c></remarks>
public sealed class ServerPaintballstandarddamageCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.paintballstandarddamage";

    /// <summary>Reads the current value of <c>server.paintballstandarddamage</c>.</summary>
    public static ServerPaintballstandarddamageCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPaintballstandarddamageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.paintballstandarddamage</c> to <paramref name="value"/>.</summary>
    public static ServerPaintballstandarddamageCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerPaintballstandarddamageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
