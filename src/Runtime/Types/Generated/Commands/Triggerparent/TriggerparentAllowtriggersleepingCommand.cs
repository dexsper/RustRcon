using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Allow triggers to sleep if both they and their contents are stationary (TickMode 1 only)</summary>
/// <remarks>Full RCON name: <c>triggerparent.allowtriggersleeping</c></remarks>
public sealed class TriggerparentAllowtriggersleepingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "triggerparent.allowtriggersleeping";

    /// <summary>Reads the current value of <c>triggerparent.allowtriggersleeping</c>.</summary>
    public static TriggerparentAllowtriggersleepingCommand CreateGet()
    {
        var cmd = CreatePackage<TriggerparentAllowtriggersleepingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>triggerparent.allowtriggersleeping</c> to <paramref name="value"/>.</summary>
    public static TriggerparentAllowtriggersleepingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<TriggerparentAllowtriggersleepingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
