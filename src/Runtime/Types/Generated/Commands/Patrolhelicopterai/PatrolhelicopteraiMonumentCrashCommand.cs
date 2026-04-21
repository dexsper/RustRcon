using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, the patrol helicopter prefers to crash into a monument area when destroyed rather than crashing in open terrain</summary>
/// <remarks>Full RCON name: <c>patrolhelicopterai.monument_crash</c></remarks>
public sealed class PatrolhelicopteraiMonumentCrashCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "patrolhelicopterai.monument_crash";

    /// <summary>Reads the current value of <c>patrolhelicopterai.monument_crash</c>.</summary>
    public static PatrolhelicopteraiMonumentCrashCommand CreateGet()
    {
        var cmd = CreatePackage<PatrolhelicopteraiMonumentCrashCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>patrolhelicopterai.monument_crash</c> to <paramref name="value"/>.</summary>
    public static PatrolhelicopteraiMonumentCrashCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PatrolhelicopteraiMonumentCrashCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
