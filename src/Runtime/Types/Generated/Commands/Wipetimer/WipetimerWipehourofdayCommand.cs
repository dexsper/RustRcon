using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Which hour to wipe? 14.5 = 2:30pm</summary>
/// <remarks>Full RCON name: <c>wipetimer.wipehourofday</c></remarks>
public sealed class WipetimerWipehourofdayCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "wipetimer.wipehourofday";

    /// <summary>Reads the current value of <c>wipetimer.wipehourofday</c>.</summary>
    public static WipetimerWipehourofdayCommand CreateGet()
    {
        var cmd = CreatePackage<WipetimerWipehourofdayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>wipetimer.wipehourofday</c> to <paramref name="value"/>.</summary>
    public static WipetimerWipehourofdayCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WipetimerWipehourofdayCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
