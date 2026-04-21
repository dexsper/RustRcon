using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>0 = off, 1 = count per frame, 2 = connection attempts, 3 = messages</summary>
/// <remarks>Full RCON name: <c>profile.profiling_rcon</c></remarks>
public sealed class ProfileProfilingRconCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.profiling_rcon";

    /// <summary>Reads the current value of <c>profile.profiling_rcon</c>.</summary>
    public static ProfileProfilingRconCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileProfilingRconCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.profiling_rcon</c> to <paramref name="value"/>.</summary>
    public static ProfileProfilingRconCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileProfilingRconCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
