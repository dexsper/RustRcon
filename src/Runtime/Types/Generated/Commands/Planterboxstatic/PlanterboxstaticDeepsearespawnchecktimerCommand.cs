using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in seconds between respawn checks for growable plants in static planter boxes inside the deep sea zone; default 600s</summary>
/// <remarks>Full RCON name: <c>planterboxstatic.deepsearespawnchecktimer</c></remarks>
public sealed class PlanterboxstaticDeepsearespawnchecktimerCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "planterboxstatic.deepsearespawnchecktimer";

    /// <summary>Reads the current value of <c>planterboxstatic.deepsearespawnchecktimer</c>.</summary>
    public static PlanterboxstaticDeepsearespawnchecktimerCommand CreateGet()
    {
        var cmd = CreatePackage<PlanterboxstaticDeepsearespawnchecktimerCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>planterboxstatic.deepsearespawnchecktimer</c> to <paramref name="value"/>.</summary>
    public static PlanterboxstaticDeepsearespawnchecktimerCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PlanterboxstaticDeepsearespawnchecktimerCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
