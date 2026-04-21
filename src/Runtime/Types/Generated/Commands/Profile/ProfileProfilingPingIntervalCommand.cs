using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How often to flush raknet stats per second</summary>
/// <remarks>Full RCON name: <c>profile.profiling_ping_interval</c></remarks>
public sealed class ProfileProfilingPingIntervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.profiling_ping_interval";

    /// <summary>Reads the current value of <c>profile.profiling_ping_interval</c>.</summary>
    public static ProfileProfilingPingIntervalCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileProfilingPingIntervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.profiling_ping_interval</c> to <paramref name="value"/>.</summary>
    public static ProfileProfilingPingIntervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ProfileProfilingPingIntervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
