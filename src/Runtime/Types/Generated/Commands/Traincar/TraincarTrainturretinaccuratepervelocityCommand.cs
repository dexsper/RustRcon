using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Chance to miss per m/s of velocity for turrets shooting players on moving trains</summary>
/// <remarks>Full RCON name: <c>traincar.trainturretinaccuratepervelocity</c></remarks>
public sealed class TraincarTrainturretinaccuratepervelocityCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "traincar.trainturretinaccuratepervelocity";

    /// <summary>Reads the current value of <c>traincar.trainturretinaccuratepervelocity</c>.</summary>
    public static TraincarTrainturretinaccuratepervelocityCommand CreateGet()
    {
        var cmd = CreatePackage<TraincarTrainturretinaccuratepervelocityCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>traincar.trainturretinaccuratepervelocity</c> to <paramref name="value"/>.</summary>
    public static TraincarTrainturretinaccuratepervelocityCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TraincarTrainturretinaccuratepervelocityCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
