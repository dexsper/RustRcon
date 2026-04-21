using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Raknet statistics, 0 = off, 2 = per connection</summary>
/// <remarks>Full RCON name: <c>profile.profiling_ping</c></remarks>
public sealed class ProfileProfilingPingCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.profiling_ping";

    /// <summary>Reads the current value of <c>profile.profiling_ping</c>.</summary>
    public static ProfileProfilingPingCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileProfilingPingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.profiling_ping</c> to <paramref name="value"/>.</summary>
    public static ProfileProfilingPingCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileProfilingPingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
