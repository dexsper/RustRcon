using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Total managed memory threshold in kilobytes above which the native profiler fires a notification; helps detect memory leaks during long server runs</summary>
/// <remarks>Full RCON name: <c>profile.notifyontotalmemkb</c></remarks>
public sealed class ProfileNotifyontotalmemkbCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.notifyontotalmemkb";

    /// <summary>Reads the current value of <c>profile.notifyontotalmemkb</c>.</summary>
    public static ProfileNotifyontotalmemkbCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileNotifyontotalmemkbCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.notifyontotalmemkb</c> to <paramref name="value"/>.</summary>
    public static ProfileNotifyontotalmemkbCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileNotifyontotalmemkbCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
