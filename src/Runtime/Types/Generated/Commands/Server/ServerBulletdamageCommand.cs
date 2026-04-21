using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Global multiplier for all bullet damage dealt by firearms; 1.0 = default, 2.0 = double damage</summary>
/// <remarks>Full RCON name: <c>server.bulletdamage</c></remarks>
public sealed class ServerBulletdamageCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.bulletdamage";

    /// <summary>Reads the current value of <c>server.bulletdamage</c>.</summary>
    public static ServerBulletdamageCommand CreateGet()
    {
        var cmd = CreatePackage<ServerBulletdamageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.bulletdamage</c> to <paramref name="value"/>.</summary>
    public static ServerBulletdamageCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerBulletdamageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
