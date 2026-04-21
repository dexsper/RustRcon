using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>junkpilewater.destroyablebyplayerboats</c>.</summary>
/// <remarks>Full RCON name: <c>junkpilewater.destroyablebyplayerboats</c></remarks>
public sealed class JunkpilewaterDestroyablebyplayerboatsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "junkpilewater.destroyablebyplayerboats";

    /// <summary>Reads the current value of <c>junkpilewater.destroyablebyplayerboats</c>.</summary>
    public static JunkpilewaterDestroyablebyplayerboatsCommand CreateGet()
    {
        var cmd = CreatePackage<JunkpilewaterDestroyablebyplayerboatsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>junkpilewater.destroyablebyplayerboats</c> to <paramref name="value"/>.</summary>
    public static JunkpilewaterDestroyablebyplayerboatsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<JunkpilewaterDestroyablebyplayerboatsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
