using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>bigwheelgame.spinfrequencyseconds</c>.</summary>
/// <remarks>Full RCON name: <c>bigwheelgame.spinfrequencyseconds</c></remarks>
public sealed class BigwheelgameSpinfrequencysecondsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bigwheelgame.spinfrequencyseconds";

    /// <summary>Reads the current value of <c>bigwheelgame.spinfrequencyseconds</c>.</summary>
    public static BigwheelgameSpinfrequencysecondsCommand CreateGet()
    {
        var cmd = CreatePackage<BigwheelgameSpinfrequencysecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bigwheelgame.spinfrequencyseconds</c> to <paramref name="value"/>.</summary>
    public static BigwheelgameSpinfrequencysecondsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BigwheelgameSpinfrequencysecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
