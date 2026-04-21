using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many milliseconds to spend on a tick per frame</summary>
/// <remarks>Full RCON name: <c>autoturret.tick_update_ms</c></remarks>
public sealed class AutoturretTickUpdateMsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "autoturret.tick_update_ms";

    /// <summary>Reads the current value of <c>autoturret.tick_update_ms</c>.</summary>
    public static AutoturretTickUpdateMsCommand CreateGet()
    {
        var cmd = CreatePackage<AutoturretTickUpdateMsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>autoturret.tick_update_ms</c> to <paramref name="value"/>.</summary>
    public static AutoturretTickUpdateMsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AutoturretTickUpdateMsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
