using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Worker-thread memory usage threshold in kilobytes for profiler notifications; 0 = disabled</summary>
/// <remarks>Full RCON name: <c>profile.notifyonworkermemkb</c></remarks>
public sealed class ProfileNotifyonworkermemkbCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.notifyonworkermemkb";

    /// <summary>Reads the current value of <c>profile.notifyonworkermemkb</c>.</summary>
    public static ProfileNotifyonworkermemkbCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileNotifyonworkermemkbCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.notifyonworkermemkb</c> to <paramref name="value"/>.</summary>
    public static ProfileNotifyonworkermemkbCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileNotifyonworkermemkbCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
