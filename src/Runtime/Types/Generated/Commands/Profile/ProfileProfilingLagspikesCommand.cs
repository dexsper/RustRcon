using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Record inbound RPC &amp; ConsoleCommands that cause lag spikes</summary>
/// <remarks>Full RCON name: <c>profile.profiling_lagspikes</c></remarks>
public sealed class ProfileProfilingLagspikesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.profiling_lagspikes";

    /// <summary>Reads the current value of <c>profile.profiling_lagspikes</c>.</summary>
    public static ProfileProfilingLagspikesCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileProfilingLagspikesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.profiling_lagspikes</c> to <paramref name="value"/>.</summary>
    public static ProfileProfilingLagspikesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ProfileProfilingLagspikesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
