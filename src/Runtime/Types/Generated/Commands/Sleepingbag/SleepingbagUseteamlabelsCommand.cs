using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>sleepingbag.useteamlabels</c>.</summary>
/// <remarks>Full RCON name: <c>sleepingbag.useteamlabels</c></remarks>
public sealed class SleepingbagUseteamlabelsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "sleepingbag.useteamlabels";

    /// <summary>Reads the current value of <c>sleepingbag.useteamlabels</c>.</summary>
    public static SleepingbagUseteamlabelsCommand CreateGet()
    {
        var cmd = CreatePackage<SleepingbagUseteamlabelsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>sleepingbag.useteamlabels</c> to <paramref name="value"/>.</summary>
    public static SleepingbagUseteamlabelsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<SleepingbagUseteamlabelsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
