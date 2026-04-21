using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, the Travelling Vendor will attempt to stop for players and perform pullover interactions along its route</summary>
/// <remarks>Full RCON name: <c>travellingvendor.attempt_pullovers</c></remarks>
public sealed class TravellingvendorAttemptPulloversCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "travellingvendor.attempt_pullovers";

    /// <summary>Reads the current value of <c>travellingvendor.attempt_pullovers</c>.</summary>
    public static TravellingvendorAttemptPulloversCommand CreateGet()
    {
        var cmd = CreatePackage<TravellingvendorAttemptPulloversCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>travellingvendor.attempt_pullovers</c> to <paramref name="value"/>.</summary>
    public static TravellingvendorAttemptPulloversCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<TravellingvendorAttemptPulloversCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
