using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>junkpile.destroyifspawnonsleepingbagtime</c>.</summary>
/// <remarks>Full RCON name: <c>junkpile.destroyifspawnonsleepingbagtime</c></remarks>
public sealed class JunkpileDestroyifspawnonsleepingbagtimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "junkpile.destroyifspawnonsleepingbagtime";

    /// <summary>Reads the current value of <c>junkpile.destroyifspawnonsleepingbagtime</c>.</summary>
    public static JunkpileDestroyifspawnonsleepingbagtimeCommand CreateGet()
    {
        var cmd = CreatePackage<JunkpileDestroyifspawnonsleepingbagtimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>junkpile.destroyifspawnonsleepingbagtime</c> to <paramref name="value"/>.</summary>
    public static JunkpileDestroyifspawnonsleepingbagtimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<JunkpileDestroyifspawnonsleepingbagtimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
