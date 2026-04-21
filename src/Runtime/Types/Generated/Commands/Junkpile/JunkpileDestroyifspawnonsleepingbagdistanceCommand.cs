using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>junkpile.destroyifspawnonsleepingbagdistance</c>.</summary>
/// <remarks>Full RCON name: <c>junkpile.destroyifspawnonsleepingbagdistance</c></remarks>
public sealed class JunkpileDestroyifspawnonsleepingbagdistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "junkpile.destroyifspawnonsleepingbagdistance";

    /// <summary>Reads the current value of <c>junkpile.destroyifspawnonsleepingbagdistance</c>.</summary>
    public static JunkpileDestroyifspawnonsleepingbagdistanceCommand CreateGet()
    {
        var cmd = CreatePackage<JunkpileDestroyifspawnonsleepingbagdistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>junkpile.destroyifspawnonsleepingbagdistance</c> to <paramref name="value"/>.</summary>
    public static JunkpileDestroyifspawnonsleepingbagdistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<JunkpileDestroyifspawnonsleepingbagdistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
