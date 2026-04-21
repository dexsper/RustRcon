using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Can we use cached state from ticks when UsePlayerUpdateJobs == 2</summary>
/// <remarks>Full RCON name: <c>triggerparent.useplayerv2shortcuts</c></remarks>
public sealed class TriggerparentUseplayerv2shortcutsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "triggerparent.useplayerv2shortcuts";

    /// <summary>Reads the current value of <c>triggerparent.useplayerv2shortcuts</c>.</summary>
    public static TriggerparentUseplayerv2shortcutsCommand CreateGet()
    {
        var cmd = CreatePackage<TriggerparentUseplayerv2shortcutsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>triggerparent.useplayerv2shortcuts</c> to <paramref name="value"/>.</summary>
    public static TriggerparentUseplayerv2shortcutsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<TriggerparentUseplayerv2shortcutsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
