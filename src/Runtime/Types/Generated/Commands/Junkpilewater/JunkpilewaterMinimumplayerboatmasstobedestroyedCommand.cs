using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>junkpilewater.minimumplayerboatmasstobedestroyed</c>.</summary>
/// <remarks>Full RCON name: <c>junkpilewater.minimumplayerboatmasstobedestroyed</c></remarks>
public sealed class JunkpilewaterMinimumplayerboatmasstobedestroyedCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "junkpilewater.minimumplayerboatmasstobedestroyed";

    /// <summary>Reads the current value of <c>junkpilewater.minimumplayerboatmasstobedestroyed</c>.</summary>
    public static JunkpilewaterMinimumplayerboatmasstobedestroyedCommand CreateGet()
    {
        var cmd = CreatePackage<JunkpilewaterMinimumplayerboatmasstobedestroyedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>junkpilewater.minimumplayerboatmasstobedestroyed</c> to <paramref name="value"/>.</summary>
    public static JunkpilewaterMinimumplayerboatmasstobedestroyedCommand CreateSet(float value)
    {
        var cmd = CreatePackage<JunkpilewaterMinimumplayerboatmasstobedestroyedCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
