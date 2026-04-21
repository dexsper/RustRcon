using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>junkpilewater.minimumplayerboatvelocitytobedestroyed</c>.</summary>
/// <remarks>Full RCON name: <c>junkpilewater.minimumplayerboatvelocitytobedestroyed</c></remarks>
public sealed class JunkpilewaterMinimumplayerboatvelocitytobedestroyedCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "junkpilewater.minimumplayerboatvelocitytobedestroyed";

    /// <summary>Reads the current value of <c>junkpilewater.minimumplayerboatvelocitytobedestroyed</c>.</summary>
    public static JunkpilewaterMinimumplayerboatvelocitytobedestroyedCommand CreateGet()
    {
        var cmd = CreatePackage<JunkpilewaterMinimumplayerboatvelocitytobedestroyedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>junkpilewater.minimumplayerboatvelocitytobedestroyed</c> to <paramref name="value"/>.</summary>
    public static JunkpilewaterMinimumplayerboatvelocitytobedestroyedCommand CreateSet(float value)
    {
        var cmd = CreatePackage<JunkpilewaterMinimumplayerboatvelocitytobedestroyedCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
