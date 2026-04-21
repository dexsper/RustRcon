using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Allows mounting cannons outside of boats for testing.</summary>
/// <remarks>Full RCON name: <c>cannon.ignore_boat_mount_restrictions</c></remarks>
public sealed class CannonIgnoreBoatMountRestrictionsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cannon.ignore_boat_mount_restrictions";

    /// <summary>Reads the current value of <c>cannon.ignore_boat_mount_restrictions</c>.</summary>
    public static CannonIgnoreBoatMountRestrictionsCommand CreateGet()
    {
        var cmd = CreatePackage<CannonIgnoreBoatMountRestrictionsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>cannon.ignore_boat_mount_restrictions</c> to <paramref name="value"/>.</summary>
    public static CannonIgnoreBoatMountRestrictionsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CannonIgnoreBoatMountRestrictionsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
