using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, draws DDraw visualisations of boat AI steering, avoidance, and pathfinding state</summary>
/// <remarks>Full RCON name: <c>boatai.draw_debugs</c></remarks>
public sealed class BoataiDrawDebugsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatai.draw_debugs";

    /// <summary>Reads the current value of <c>boatai.draw_debugs</c>.</summary>
    public static BoataiDrawDebugsCommand CreateGet()
    {
        var cmd = CreatePackage<BoataiDrawDebugsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatai.draw_debugs</c> to <paramref name="value"/>.</summary>
    public static BoataiDrawDebugsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BoataiDrawDebugsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
