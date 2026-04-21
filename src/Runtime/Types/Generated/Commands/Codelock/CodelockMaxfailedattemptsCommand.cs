using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of failed code entry attempts on a code lock before the player is locked out; default 8</summary>
/// <remarks>Full RCON name: <c>codelock.maxfailedattempts</c></remarks>
public sealed class CodelockMaxfailedattemptsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "codelock.maxfailedattempts";

    /// <summary>Reads the current value of <c>codelock.maxfailedattempts</c>.</summary>
    public static CodelockMaxfailedattemptsCommand CreateGet()
    {
        var cmd = CreatePackage<CodelockMaxfailedattemptsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>codelock.maxfailedattempts</c> to <paramref name="value"/>.</summary>
    public static CodelockMaxfailedattemptsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<CodelockMaxfailedattemptsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
