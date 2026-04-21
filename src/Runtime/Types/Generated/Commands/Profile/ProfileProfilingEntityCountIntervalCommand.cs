using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How frequently to count all entities across the server</summary>
/// <remarks>Full RCON name: <c>profile.profiling_entity_count_interval</c></remarks>
public sealed class ProfileProfilingEntityCountIntervalCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.profiling_entity_count_interval";

    /// <summary>Reads the current value of <c>profile.profiling_entity_count_interval</c>.</summary>
    public static ProfileProfilingEntityCountIntervalCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileProfilingEntityCountIntervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.profiling_entity_count_interval</c> to <paramref name="value"/>.</summary>
    public static ProfileProfilingEntityCountIntervalCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileProfilingEntityCountIntervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
