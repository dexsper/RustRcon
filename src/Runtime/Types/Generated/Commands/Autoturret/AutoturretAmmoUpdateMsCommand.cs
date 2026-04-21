using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many milliseconds to spend on ammo updating per frame</summary>
/// <remarks>Full RCON name: <c>autoturret.ammo_update_ms</c></remarks>
public sealed class AutoturretAmmoUpdateMsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "autoturret.ammo_update_ms";

    /// <summary>Reads the current value of <c>autoturret.ammo_update_ms</c>.</summary>
    public static AutoturretAmmoUpdateMsCommand CreateGet()
    {
        var cmd = CreatePackage<AutoturretAmmoUpdateMsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>autoturret.ammo_update_ms</c> to <paramref name="value"/>.</summary>
    public static AutoturretAmmoUpdateMsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AutoturretAmmoUpdateMsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
