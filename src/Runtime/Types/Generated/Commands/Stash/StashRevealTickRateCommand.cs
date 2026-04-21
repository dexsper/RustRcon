using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in seconds between player-detection ticks for the stash container reveal mechanic; registered as stash.reveal_tick_rate</summary>
/// <remarks>Full RCON name: <c>stash.reveal_tick_rate</c></remarks>
public sealed class StashRevealTickRateCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "stash.reveal_tick_rate";

    /// <summary>Reads the current value of <c>stash.reveal_tick_rate</c>.</summary>
    public static StashRevealTickRateCommand CreateGet()
    {
        var cmd = CreatePackage<StashRevealTickRateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>stash.reveal_tick_rate</c> to <paramref name="value"/>.</summary>
    public static StashRevealTickRateCommand CreateSet(float value)
    {
        var cmd = CreatePackage<StashRevealTickRateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
