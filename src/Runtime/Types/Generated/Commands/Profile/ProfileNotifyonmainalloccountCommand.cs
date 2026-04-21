using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Main-thread allocation count threshold per tick for profiler notifications; 0 = disabled; helps isolate main-thread GC pressure</summary>
/// <remarks>Full RCON name: <c>profile.notifyonmainalloccount</c></remarks>
public sealed class ProfileNotifyonmainalloccountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.notifyonmainalloccount";

    /// <summary>Reads the current value of <c>profile.notifyonmainalloccount</c>.</summary>
    public static ProfileNotifyonmainalloccountCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileNotifyonmainalloccountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.notifyonmainalloccount</c> to <paramref name="value"/>.</summary>
    public static ProfileNotifyonmainalloccountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileNotifyonmainalloccountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
