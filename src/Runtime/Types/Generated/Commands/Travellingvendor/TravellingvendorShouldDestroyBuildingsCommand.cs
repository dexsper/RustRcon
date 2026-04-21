using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, the Travelling Vendor will destroy player-placed buildings that block its ring road path</summary>
/// <remarks>Full RCON name: <c>travellingvendor.should_destroy_buildings</c></remarks>
public sealed class TravellingvendorShouldDestroyBuildingsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "travellingvendor.should_destroy_buildings";

    /// <summary>Reads the current value of <c>travellingvendor.should_destroy_buildings</c>.</summary>
    public static TravellingvendorShouldDestroyBuildingsCommand CreateGet()
    {
        var cmd = CreatePackage<TravellingvendorShouldDestroyBuildingsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>travellingvendor.should_destroy_buildings</c> to <paramref name="value"/>.</summary>
    public static TravellingvendorShouldDestroyBuildingsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<TravellingvendorShouldDestroyBuildingsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
