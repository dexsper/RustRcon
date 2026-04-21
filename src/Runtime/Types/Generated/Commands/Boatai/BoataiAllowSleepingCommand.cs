using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, boat AI entities can enter a sleep state when no players are nearby; reduce CPU usage for idle boats</summary>
/// <remarks>Full RCON name: <c>boatai.allow_sleeping</c></remarks>
public sealed class BoataiAllowSleepingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatai.allow_sleeping";

    /// <summary>Reads the current value of <c>boatai.allow_sleeping</c>.</summary>
    public static BoataiAllowSleepingCommand CreateGet()
    {
        var cmd = CreatePackage<BoataiAllowSleepingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatai.allow_sleeping</c> to <paramref name="value"/>.</summary>
    public static BoataiAllowSleepingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BoataiAllowSleepingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
