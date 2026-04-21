using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server, per square km</summary>
/// <remarks>Full RCON name: <c>halloween.scarecrowpopulation</c></remarks>
public sealed class HalloweenScarecrowpopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "halloween.scarecrowpopulation";

    /// <summary>Reads the current value of <c>halloween.scarecrowpopulation</c>.</summary>
    public static HalloweenScarecrowpopulationCommand CreateGet()
    {
        var cmd = CreatePackage<HalloweenScarecrowpopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>halloween.scarecrowpopulation</c> to <paramref name="value"/>.</summary>
    public static HalloweenScarecrowpopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HalloweenScarecrowpopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
