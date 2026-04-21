using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of consecutive ground-watch failures allowed before corrective action is taken on a player who appears to be falling through geometry</summary>
/// <remarks>Full RCON name: <c>physics.groundwatchfails</c></remarks>
public sealed class PhysicsGroundwatchfailsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.groundwatchfails";

    /// <summary>Reads the current value of <c>physics.groundwatchfails</c>.</summary>
    public static PhysicsGroundwatchfailsCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsGroundwatchfailsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.groundwatchfails</c> to <paramref name="value"/>.</summary>
    public static PhysicsGroundwatchfailsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<PhysicsGroundwatchfailsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
