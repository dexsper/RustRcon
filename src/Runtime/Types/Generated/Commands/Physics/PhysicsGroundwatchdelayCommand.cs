using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Seconds between ground-watch checks on a player; lower values detect world-fall issues faster but increase CPU overhead</summary>
/// <remarks>Full RCON name: <c>physics.groundwatchdelay</c></remarks>
public sealed class PhysicsGroundwatchdelayCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.groundwatchdelay";

    /// <summary>Reads the current value of <c>physics.groundwatchdelay</c>.</summary>
    public static PhysicsGroundwatchdelayCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsGroundwatchdelayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.groundwatchdelay</c> to <paramref name="value"/>.</summary>
    public static PhysicsGroundwatchdelayCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PhysicsGroundwatchdelayCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
