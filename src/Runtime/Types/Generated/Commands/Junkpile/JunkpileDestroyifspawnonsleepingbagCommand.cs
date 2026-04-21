using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>junkpile.destroyifspawnonsleepingbag</c>.</summary>
/// <remarks>Full RCON name: <c>junkpile.destroyifspawnonsleepingbag</c></remarks>
public sealed class JunkpileDestroyifspawnonsleepingbagCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "junkpile.destroyifspawnonsleepingbag";

    /// <summary>Reads the current value of <c>junkpile.destroyifspawnonsleepingbag</c>.</summary>
    public static JunkpileDestroyifspawnonsleepingbagCommand CreateGet()
    {
        var cmd = CreatePackage<JunkpileDestroyifspawnonsleepingbagCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>junkpile.destroyifspawnonsleepingbag</c> to <paramref name="value"/>.</summary>
    public static JunkpileDestroyifspawnonsleepingbagCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<JunkpileDestroyifspawnonsleepingbagCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
