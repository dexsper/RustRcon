using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Ratio of wagons to train engines that spawn</summary>
/// <remarks>Full RCON name: <c>traincar.wagons_per_engine</c></remarks>
public sealed class TraincarWagonsPerEngineCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "traincar.wagons_per_engine";

    /// <summary>Reads the current value of <c>traincar.wagons_per_engine</c>.</summary>
    public static TraincarWagonsPerEngineCommand CreateGet()
    {
        var cmd = CreatePackage<TraincarWagonsPerEngineCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>traincar.wagons_per_engine</c> to <paramref name="value"/>.</summary>
    public static TraincarWagonsPerEngineCommand CreateSet(int value)
    {
        var cmd = CreatePackage<TraincarWagonsPerEngineCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
