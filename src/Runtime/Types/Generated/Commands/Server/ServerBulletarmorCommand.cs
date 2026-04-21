using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Global multiplier for armour effectiveness against bullet damage; 1.0 = default</summary>
/// <remarks>Full RCON name: <c>server.bulletarmor</c></remarks>
public sealed class ServerBulletarmorCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.bulletarmor";

    /// <summary>Reads the current value of <c>server.bulletarmor</c>.</summary>
    public static ServerBulletarmorCommand CreateGet()
    {
        var cmd = CreatePackage<ServerBulletarmorCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.bulletarmor</c> to <paramref name="value"/>.</summary>
    public static ServerBulletarmorCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerBulletarmorCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
