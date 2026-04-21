using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Clamp the length of logged RCON messages to prevent the profiler from being flooded with large messages</summary>
/// <remarks>Full RCON name: <c>profile.profiling_rcon_message_length</c></remarks>
public sealed class ProfileProfilingRconMessageLengthCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.profiling_rcon_message_length";

    /// <summary>Reads the current value of <c>profile.profiling_rcon_message_length</c>.</summary>
    public static ProfileProfilingRconMessageLengthCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileProfilingRconMessageLengthCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.profiling_rcon_message_length</c> to <paramref name="value"/>.</summary>
    public static ProfileProfilingRconMessageLengthCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileProfilingRconMessageLengthCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
