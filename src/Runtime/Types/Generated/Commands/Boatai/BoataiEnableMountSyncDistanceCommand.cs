using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Distance players need to be to start syncing mounted seats</summary>
/// <remarks>Full RCON name: <c>boatai.enable_mount_sync_distance</c></remarks>
public sealed class BoataiEnableMountSyncDistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatai.enable_mount_sync_distance";

    /// <summary>Reads the current value of <c>boatai.enable_mount_sync_distance</c>.</summary>
    public static BoataiEnableMountSyncDistanceCommand CreateGet()
    {
        var cmd = CreatePackage<BoataiEnableMountSyncDistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatai.enable_mount_sync_distance</c> to <paramref name="value"/>.</summary>
    public static BoataiEnableMountSyncDistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BoataiEnableMountSyncDistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
