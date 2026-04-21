using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, triggers use an exclude layer mask to filter out specific physics layers from trigger detection; toggling clears or sets all active triggers</summary>
/// <remarks>Full RCON name: <c>triggerbase.useexcludelayers</c></remarks>
public sealed class TriggerbaseUseexcludelayersCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "triggerbase.useexcludelayers";

    /// <summary>Reads the current value of <c>triggerbase.useexcludelayers</c>.</summary>
    public static TriggerbaseUseexcludelayersCommand CreateGet()
    {
        var cmd = CreatePackage<TriggerbaseUseexcludelayersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>triggerbase.useexcludelayers</c> to <paramref name="value"/>.</summary>
    public static TriggerbaseUseexcludelayersCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<TriggerbaseUseexcludelayersCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
