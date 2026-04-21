using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, the patrol helicopter avoids designated danger zones during its patrol route</summary>
/// <remarks>Full RCON name: <c>patrolhelicopterai.use_danger_zones</c></remarks>
public sealed class PatrolhelicopteraiUseDangerZonesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "patrolhelicopterai.use_danger_zones";

    /// <summary>Reads the current value of <c>patrolhelicopterai.use_danger_zones</c>.</summary>
    public static PatrolhelicopteraiUseDangerZonesCommand CreateGet()
    {
        var cmd = CreatePackage<PatrolhelicopteraiUseDangerZonesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>patrolhelicopterai.use_danger_zones</c> to <paramref name="value"/>.</summary>
    public static PatrolhelicopteraiUseDangerZonesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PatrolhelicopteraiUseDangerZonesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
