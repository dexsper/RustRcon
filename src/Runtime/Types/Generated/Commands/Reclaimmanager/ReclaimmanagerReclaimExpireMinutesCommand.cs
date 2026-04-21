using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Time in minutes after which an uncollected softcore death reclaim backpack expires and its contents are destroyed</summary>
/// <remarks>Full RCON name: <c>reclaimmanager.reclaim_expire_minutes</c></remarks>
public sealed class ReclaimmanagerReclaimExpireMinutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "reclaimmanager.reclaim_expire_minutes";

    /// <summary>Reads the current value of <c>reclaimmanager.reclaim_expire_minutes</c>.</summary>
    public static ReclaimmanagerReclaimExpireMinutesCommand CreateGet()
    {
        var cmd = CreatePackage<ReclaimmanagerReclaimExpireMinutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>reclaimmanager.reclaim_expire_minutes</c> to <paramref name="value"/>.</summary>
    public static ReclaimmanagerReclaimExpireMinutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ReclaimmanagerReclaimExpireMinutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
