using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before an unloadable train car despawns afer being unloaded</summary>
/// <remarks>Full RCON name: <c>traincarunloadable.decayminutesafterunload</c></remarks>
public sealed class TraincarunloadableDecayminutesafterunloadCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "traincarunloadable.decayminutesafterunload";

    /// <summary>Reads the current value of <c>traincarunloadable.decayminutesafterunload</c>.</summary>
    public static TraincarunloadableDecayminutesafterunloadCommand CreateGet()
    {
        var cmd = CreatePackage<TraincarunloadableDecayminutesafterunloadCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>traincarunloadable.decayminutesafterunload</c> to <paramref name="value"/>.</summary>
    public static TraincarunloadableDecayminutesafterunloadCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TraincarunloadableDecayminutesafterunloadCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
