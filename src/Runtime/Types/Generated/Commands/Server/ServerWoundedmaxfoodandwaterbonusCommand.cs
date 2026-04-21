using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Maximum percent chance added to base wounded/incapacitated recovery chance, based on the player's food and water level</summary>
/// <remarks>Full RCON name: <c>server.woundedmaxfoodandwaterbonus</c></remarks>
public sealed class ServerWoundedmaxfoodandwaterbonusCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.woundedmaxfoodandwaterbonus";

    /// <summary>Reads the current value of <c>server.woundedmaxfoodandwaterbonus</c>.</summary>
    public static ServerWoundedmaxfoodandwaterbonusCommand CreateGet()
    {
        var cmd = CreatePackage<ServerWoundedmaxfoodandwaterbonusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.woundedmaxfoodandwaterbonus</c> to <paramref name="value"/>.</summary>
    public static ServerWoundedmaxfoodandwaterbonusCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerWoundedmaxfoodandwaterbonusCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
