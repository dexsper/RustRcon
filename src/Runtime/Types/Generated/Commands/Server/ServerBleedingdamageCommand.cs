using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Global multiplier for all bleeding damage over time; 1.0 = default</summary>
/// <remarks>Full RCON name: <c>server.bleedingdamage</c></remarks>
public sealed class ServerBleedingdamageCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.bleedingdamage";

    /// <summary>Reads the current value of <c>server.bleedingdamage</c>.</summary>
    public static ServerBleedingdamageCommand CreateGet()
    {
        var cmd = CreatePackage<ServerBleedingdamageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.bleedingdamage</c> to <paramref name="value"/>.</summary>
    public static ServerBleedingdamageCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerBleedingdamageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
