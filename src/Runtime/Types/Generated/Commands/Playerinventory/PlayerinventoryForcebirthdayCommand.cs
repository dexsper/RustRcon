using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, forces the birthday event state to true regardless of the actual date; overrides IsBirthday() calendar check for testing</summary>
/// <remarks>Full RCON name: <c>playerinventory.forcebirthday</c></remarks>
public sealed class PlayerinventoryForcebirthdayCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerinventory.forcebirthday";

    /// <summary>Reads the current value of <c>playerinventory.forcebirthday</c>.</summary>
    public static PlayerinventoryForcebirthdayCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerinventoryForcebirthdayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerinventory.forcebirthday</c> to <paramref name="value"/>.</summary>
    public static PlayerinventoryForcebirthdayCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PlayerinventoryForcebirthdayCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
