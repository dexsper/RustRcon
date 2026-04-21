using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server</summary>
/// <remarks>Full RCON name: <c>traincar.population</c></remarks>
public sealed class TraincarPopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "traincar.population";

    /// <summary>Reads the current value of <c>traincar.population</c>.</summary>
    public static TraincarPopulationCommand CreateGet()
    {
        var cmd = CreatePackage<TraincarPopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>traincar.population</c> to <paramref name="value"/>.</summary>
    public static TraincarPopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TraincarPopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
