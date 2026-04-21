using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>0 - old InvokeHandler, 1 - Jobs</summary>
/// <remarks>Full RCON name: <c>triggerparent.tickmode</c></remarks>
public sealed class TriggerparentTickmodeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "triggerparent.tickmode";

    /// <summary>Reads the current value of <c>triggerparent.tickmode</c>.</summary>
    public static TriggerparentTickmodeCommand CreateGet()
    {
        var cmd = CreatePackage<TriggerparentTickmodeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>triggerparent.tickmode</c> to <paramref name="value"/>.</summary>
    public static TriggerparentTickmodeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<TriggerparentTickmodeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
