using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Worker-thread allocation count threshold per tick for profiler notifications; 0 = disabled; helps detect background task GC pressure</summary>
/// <remarks>Full RCON name: <c>profile.notifyonworkeralloccount</c></remarks>
public sealed class ProfileNotifyonworkeralloccountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.notifyonworkeralloccount";

    /// <summary>Reads the current value of <c>profile.notifyonworkeralloccount</c>.</summary>
    public static ProfileNotifyonworkeralloccountCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileNotifyonworkeralloccountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.notifyonworkeralloccount</c> to <paramref name="value"/>.</summary>
    public static ProfileNotifyonworkeralloccountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileNotifyonworkeralloccountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
