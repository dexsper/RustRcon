using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Cone angle in degrees for randomizing tumbling force direction</summary>
/// <remarks>Full RCON name: <c>physicstumblingentity.tumbling_force_cone_angle</c></remarks>
public sealed class PhysicstumblingentityTumblingForceConeAngleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physicstumblingentity.tumbling_force_cone_angle";

    /// <summary>Reads the current value of <c>physicstumblingentity.tumbling_force_cone_angle</c>.</summary>
    public static PhysicstumblingentityTumblingForceConeAngleCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicstumblingentityTumblingForceConeAngleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physicstumblingentity.tumbling_force_cone_angle</c> to <paramref name="value"/>.</summary>
    public static PhysicstumblingentityTumblingForceConeAngleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PhysicstumblingentityTumblingForceConeAngleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
