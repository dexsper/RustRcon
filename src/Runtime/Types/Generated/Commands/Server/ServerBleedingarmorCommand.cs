using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Global multiplier for armour effectiveness against bleeding damage; 1.0 = default</summary>
/// <remarks>Full RCON name: <c>server.bleedingarmor</c></remarks>
public sealed class ServerBleedingarmorCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.bleedingarmor";

    /// <summary>Reads the current value of <c>server.bleedingarmor</c>.</summary>
    public static ServerBleedingarmorCommand CreateGet()
    {
        var cmd = CreatePackage<ServerBleedingarmorCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.bleedingarmor</c> to <paramref name="value"/>.</summary>
    public static ServerBleedingarmorCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerBleedingarmorCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
