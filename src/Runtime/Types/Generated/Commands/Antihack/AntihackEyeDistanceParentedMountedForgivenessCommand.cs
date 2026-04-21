using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.eye_distance_parented_mounted_forgiveness</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.eye_distance_parented_mounted_forgiveness</c></remarks>
public sealed class AntihackEyeDistanceParentedMountedForgivenessCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.eye_distance_parented_mounted_forgiveness";

    /// <summary>Reads the current value of <c>antihack.eye_distance_parented_mounted_forgiveness</c>.</summary>
    public static AntihackEyeDistanceParentedMountedForgivenessCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackEyeDistanceParentedMountedForgivenessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.eye_distance_parented_mounted_forgiveness</c> to <paramref name="value"/>.</summary>
    public static AntihackEyeDistanceParentedMountedForgivenessCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackEyeDistanceParentedMountedForgivenessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
