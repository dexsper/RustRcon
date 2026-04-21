using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, logs detailed debug output for building privilege (tool cupboard auth) checks during decay calculations</summary>
/// <remarks>Full RCON name: <c>decayentity.debuggetprivilege</c></remarks>
public sealed class DecayentityDebuggetprivilegeCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decayentity.debuggetprivilege";

    /// <summary>Reads the current value of <c>decayentity.debuggetprivilege</c>.</summary>
    public static DecayentityDebuggetprivilegeCommand CreateGet()
    {
        var cmd = CreatePackage<DecayentityDebuggetprivilegeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decayentity.debuggetprivilege</c> to <paramref name="value"/>.</summary>
    public static DecayentityDebuggetprivilegeCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DecayentityDebuggetprivilegeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
