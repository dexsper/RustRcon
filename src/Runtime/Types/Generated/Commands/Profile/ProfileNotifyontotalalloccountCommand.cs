using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Allocation count threshold (per profiler tick) above which the native continuous profiler fires a notification; useful for detecting unexpected allocation spikes</summary>
/// <remarks>Full RCON name: <c>profile.notifyontotalalloccount</c></remarks>
public sealed class ProfileNotifyontotalalloccountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.notifyontotalalloccount";

    /// <summary>Reads the current value of <c>profile.notifyontotalalloccount</c>.</summary>
    public static ProfileNotifyontotalalloccountCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileNotifyontotalalloccountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.notifyontotalalloccount</c> to <paramref name="value"/>.</summary>
    public static ProfileNotifyontotalalloccountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileNotifyontotalalloccountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
