using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Should explosives parented to vehicles damage deployables</summary>
/// <remarks>Full RCON name: <c>antihack.explosive_vehicle_parent_damage_deployables</c></remarks>
public sealed class AntihackExplosiveVehicleParentDamageDeployablesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.explosive_vehicle_parent_damage_deployables";

    /// <summary>Reads the current value of <c>antihack.explosive_vehicle_parent_damage_deployables</c>.</summary>
    public static AntihackExplosiveVehicleParentDamageDeployablesCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackExplosiveVehicleParentDamageDeployablesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.explosive_vehicle_parent_damage_deployables</c> to <paramref name="value"/>.</summary>
    public static AntihackExplosiveVehicleParentDamageDeployablesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackExplosiveVehicleParentDamageDeployablesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
