using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before a train car despawns</summary>
/// <remarks>Full RCON name: <c>traincar.decayminutes</c></remarks>
public sealed class TraincarDecayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "traincar.decayminutes";

    /// <summary>Reads the current value of <c>traincar.decayminutes</c>.</summary>
    public static TraincarDecayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<TraincarDecayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>traincar.decayminutes</c> to <paramref name="value"/>.</summary>
    public static TraincarDecayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TraincarDecayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
