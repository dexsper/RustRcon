using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Global multiplier for armour effectiveness against arrow and bow damage; 1.0 = default</summary>
/// <remarks>Full RCON name: <c>server.arrowarmor</c></remarks>
public sealed class ServerArrowarmorCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.arrowarmor";

    /// <summary>Reads the current value of <c>server.arrowarmor</c>.</summary>
    public static ServerArrowarmorCommand CreateGet()
    {
        var cmd = CreatePackage<ServerArrowarmorCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.arrowarmor</c> to <paramref name="value"/>.</summary>
    public static ServerArrowarmorCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerArrowarmorCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
