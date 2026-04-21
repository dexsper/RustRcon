using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Duration in seconds a player is locked out from attempting the code lock after exceeding maxFailedAttempts; default 900s (15 minutes)</summary>
/// <remarks>Full RCON name: <c>codelock.lockoutcooldown</c></remarks>
public sealed class CodelockLockoutcooldownCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "codelock.lockoutcooldown";

    /// <summary>Reads the current value of <c>codelock.lockoutcooldown</c>.</summary>
    public static CodelockLockoutcooldownCommand CreateGet()
    {
        var cmd = CreatePackage<CodelockLockoutcooldownCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>codelock.lockoutcooldown</c> to <paramref name="value"/>.</summary>
    public static CodelockLockoutcooldownCommand CreateSet(float value)
    {
        var cmd = CreatePackage<CodelockLockoutcooldownCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
