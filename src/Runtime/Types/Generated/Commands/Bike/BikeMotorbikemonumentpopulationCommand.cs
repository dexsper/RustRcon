using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Motorbike population in monuments</summary>
/// <remarks>Full RCON name: <c>bike.motorbikemonumentpopulation</c></remarks>
public sealed class BikeMotorbikemonumentpopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bike.motorbikemonumentpopulation";

    /// <summary>Reads the current value of <c>bike.motorbikemonumentpopulation</c>.</summary>
    public static BikeMotorbikemonumentpopulationCommand CreateGet()
    {
        var cmd = CreatePackage<BikeMotorbikemonumentpopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bike.motorbikemonumentpopulation</c> to <paramref name="value"/>.</summary>
    public static BikeMotorbikemonumentpopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BikeMotorbikemonumentpopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
