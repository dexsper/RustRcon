using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Global multiplier for all arrow and bow damage dealt; 1.0 = default, 2.0 = double damage</summary>
/// <remarks>Full RCON name: <c>server.arrowdamage</c></remarks>
public sealed class ServerArrowdamageCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.arrowdamage";

    /// <summary>Reads the current value of <c>server.arrowdamage</c>.</summary>
    public static ServerArrowdamageCommand CreateGet()
    {
        var cmd = CreatePackage<ServerArrowdamageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.arrowdamage</c> to <paramref name="value"/>.</summary>
    public static ServerArrowdamageCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerArrowdamageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
