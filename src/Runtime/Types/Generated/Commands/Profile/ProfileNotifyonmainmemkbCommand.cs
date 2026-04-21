using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Main-thread memory usage threshold in kilobytes for profiler notifications; 0 = disabled</summary>
/// <remarks>Full RCON name: <c>profile.notifyonmainmemkb</c></remarks>
public sealed class ProfileNotifyonmainmemkbCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.notifyonmainmemkb";

    /// <summary>Reads the current value of <c>profile.notifyonmainmemkb</c>.</summary>
    public static ProfileNotifyonmainmemkbCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileNotifyonmainmemkbCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.notifyonmainmemkb</c> to <paramref name="value"/>.</summary>
    public static ProfileNotifyonmainmemkbCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileNotifyonmainmemkbCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
