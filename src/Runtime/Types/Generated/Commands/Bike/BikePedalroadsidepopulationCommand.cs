using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Pedal bike population active on the server (roadside spawns)</summary>
/// <remarks>Full RCON name: <c>bike.pedalroadsidepopulation</c></remarks>
public sealed class BikePedalroadsidepopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bike.pedalroadsidepopulation";

    /// <summary>Reads the current value of <c>bike.pedalroadsidepopulation</c>.</summary>
    public static BikePedalroadsidepopulationCommand CreateGet()
    {
        var cmd = CreatePackage<BikePedalroadsidepopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bike.pedalroadsidepopulation</c> to <paramref name="value"/>.</summary>
    public static BikePedalroadsidepopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BikePedalroadsidepopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
