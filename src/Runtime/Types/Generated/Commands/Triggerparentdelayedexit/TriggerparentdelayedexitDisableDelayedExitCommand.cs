using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Makes TriggerParentDelayedExit act as a TriggerParent again</summary>
/// <remarks>Full RCON name: <c>triggerparentdelayedexit.disable_delayed_exit</c></remarks>
public sealed class TriggerparentdelayedexitDisableDelayedExitCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "triggerparentdelayedexit.disable_delayed_exit";

    /// <summary>Reads the current value of <c>triggerparentdelayedexit.disable_delayed_exit</c>.</summary>
    public static TriggerparentdelayedexitDisableDelayedExitCommand CreateGet()
    {
        var cmd = CreatePackage<TriggerparentdelayedexitDisableDelayedExitCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>triggerparentdelayedexit.disable_delayed_exit</c> to <paramref name="value"/>.</summary>
    public static TriggerparentdelayedexitDisableDelayedExitCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<TriggerparentdelayedexitDisableDelayedExitCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
