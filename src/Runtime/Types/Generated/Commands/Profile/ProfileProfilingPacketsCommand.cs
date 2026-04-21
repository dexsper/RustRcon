using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Record type of packets inbound/outbound per frame</summary>
/// <remarks>Full RCON name: <c>profile.profiling_packets</c></remarks>
public sealed class ProfileProfilingPacketsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.profiling_packets";

    /// <summary>Reads the current value of <c>profile.profiling_packets</c>.</summary>
    public static ProfileProfilingPacketsCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileProfilingPacketsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.profiling_packets</c> to <paramref name="value"/>.</summary>
    public static ProfileProfilingPacketsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ProfileProfilingPacketsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
