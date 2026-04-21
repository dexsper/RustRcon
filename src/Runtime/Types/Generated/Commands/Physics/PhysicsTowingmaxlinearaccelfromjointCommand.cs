using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum linear acceleration (m/s^2) that a vehicle towing joint can apply before the joint breaks; prevents unrealistic joint forces during towing</summary>
/// <remarks>Full RCON name: <c>physics.towingmaxlinearaccelfromjoint</c></remarks>
public sealed class PhysicsTowingmaxlinearaccelfromjointCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.towingmaxlinearaccelfromjoint";

    /// <summary>Reads the current value of <c>physics.towingmaxlinearaccelfromjoint</c>.</summary>
    public static PhysicsTowingmaxlinearaccelfromjointCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsTowingmaxlinearaccelfromjointCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.towingmaxlinearaccelfromjoint</c> to <paramref name="value"/>.</summary>
    public static PhysicsTowingmaxlinearaccelfromjointCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PhysicsTowingmaxlinearaccelfromjointCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
