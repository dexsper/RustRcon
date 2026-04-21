using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Pedal bike population in monuments</summary>
/// <remarks>Full RCON name: <c>bike.pedalmonumentpopulation</c></remarks>
public sealed class BikePedalmonumentpopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bike.pedalmonumentpopulation";

    /// <summary>Reads the current value of <c>bike.pedalmonumentpopulation</c>.</summary>
    public static BikePedalmonumentpopulationCommand CreateGet()
    {
        var cmd = CreatePackage<BikePedalmonumentpopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bike.pedalmonumentpopulation</c> to <paramref name="value"/>.</summary>
    public static BikePedalmonumentpopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BikePedalmonumentpopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
