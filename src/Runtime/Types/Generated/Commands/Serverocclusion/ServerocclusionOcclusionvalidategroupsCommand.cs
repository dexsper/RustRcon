using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Validates that all server occlusion network groups are correctly mapped to their occlusion data; reports any inconsistencies found</summary>
/// <remarks>Full RCON name: <c>serverocclusion.occlusionvalidategroups</c></remarks>
public sealed class ServerocclusionOcclusionvalidategroupsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "serverocclusion.occlusionvalidategroups";

    /// <summary>Creates a new <see cref="ServerocclusionOcclusionvalidategroupsCommand"/> command.</summary>
    public static ServerocclusionOcclusionvalidategroupsCommand Create()
    {
        var cmd = CreatePackage<ServerocclusionOcclusionvalidategroupsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
