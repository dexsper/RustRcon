using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>profile.profiling_ping_per_frame</c>.</summary>
/// <remarks>Full RCON name: <c>profile.profiling_ping_per_frame</c></remarks>
public sealed class ProfileProfilingPingPerFrameCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.profiling_ping_per_frame";

    /// <summary>Reads the current value of <c>profile.profiling_ping_per_frame</c>.</summary>
    public static ProfileProfilingPingPerFrameCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileProfilingPingPerFrameCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.profiling_ping_per_frame</c> to <paramref name="value"/>.</summary>
    public static ProfileProfilingPingPerFrameCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileProfilingPingPerFrameCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
