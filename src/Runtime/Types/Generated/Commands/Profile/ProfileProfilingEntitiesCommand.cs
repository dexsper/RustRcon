using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>0 = off, 1 = spawn/kill, 2 = spawn/kill per entity, 3 = count every '5 min'</summary>
/// <remarks>Full RCON name: <c>profile.profiling_entities</c></remarks>
public sealed class ProfileProfilingEntitiesCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.profiling_entities";

    /// <summary>Reads the current value of <c>profile.profiling_entities</c>.</summary>
    public static ProfileProfilingEntitiesCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileProfilingEntitiesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.profiling_entities</c> to <paramref name="value"/>.</summary>
    public static ProfileProfilingEntitiesCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileProfilingEntitiesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
