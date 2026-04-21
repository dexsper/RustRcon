using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Generate a performance capture containing the next run of updateMissionValidStateWorkQueue</summary>
/// <remarks>Full RCON name: <c>basemission.profilenextmissionsvalidstateworkqueue</c></remarks>
public sealed class BasemissionProfilenextmissionsvalidstateworkqueueCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basemission.profilenextmissionsvalidstateworkqueue";

    /// <summary>Creates a new <see cref="BasemissionProfilenextmissionsvalidstateworkqueueCommand"/> command.</summary>
    public static BasemissionProfilenextmissionsvalidstateworkqueueCommand Create()
    {
        var cmd = CreatePackage<BasemissionProfilenextmissionsvalidstateworkqueueCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
