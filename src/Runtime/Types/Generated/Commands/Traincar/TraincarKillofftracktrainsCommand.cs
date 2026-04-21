using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Should train cars that are not spawned near train tracks be killed instantly (default = true)</summary>
/// <remarks>Full RCON name: <c>traincar.killofftracktrains</c></remarks>
public sealed class TraincarKillofftracktrainsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "traincar.killofftracktrains";

    /// <summary>Reads the current value of <c>traincar.killofftracktrains</c>.</summary>
    public static TraincarKillofftracktrainsCommand CreateGet()
    {
        var cmd = CreatePackage<TraincarKillofftracktrainsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>traincar.killofftracktrains</c> to <paramref name="value"/>.</summary>
    public static TraincarKillofftracktrainsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<TraincarKillofftracktrainsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
