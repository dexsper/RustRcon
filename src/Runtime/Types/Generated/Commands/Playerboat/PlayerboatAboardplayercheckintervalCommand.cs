using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in seconds between checks to determine whether any players are still aboard the boat</summary>
/// <remarks>Full RCON name: <c>playerboat.aboardplayercheckinterval</c></remarks>
public sealed class PlayerboatAboardplayercheckintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.aboardplayercheckinterval";

    /// <summary>Reads the current value of <c>playerboat.aboardplayercheckinterval</c>.</summary>
    public static PlayerboatAboardplayercheckintervalCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatAboardplayercheckintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.aboardplayercheckinterval</c> to <paramref name="value"/>.</summary>
    public static PlayerboatAboardplayercheckintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PlayerboatAboardplayercheckintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
