using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of seconds a boat AI will wait without player interaction before entering sleep mode; default 30s</summary>
/// <remarks>Full RCON name: <c>boatai.seconds_until_sleep</c></remarks>
public sealed class BoataiSecondsUntilSleepCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatai.seconds_until_sleep";

    /// <summary>Reads the current value of <c>boatai.seconds_until_sleep</c>.</summary>
    public static BoataiSecondsUntilSleepCommand CreateGet()
    {
        var cmd = CreatePackage<BoataiSecondsUntilSleepCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatai.seconds_until_sleep</c> to <paramref name="value"/>.</summary>
    public static BoataiSecondsUntilSleepCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BoataiSecondsUntilSleepCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
