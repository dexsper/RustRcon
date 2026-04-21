using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Global multiplier for armour effectiveness against melee damage; 1.0 = default, values above 1.0 make armour stronger against melee</summary>
/// <remarks>Full RCON name: <c>server.meleearmor</c></remarks>
public sealed class ServerMeleearmorCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.meleearmor";

    /// <summary>Reads the current value of <c>server.meleearmor</c>.</summary>
    public static ServerMeleearmorCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMeleearmorCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.meleearmor</c> to <paramref name="value"/>.</summary>
    public static ServerMeleearmorCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerMeleearmorCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
