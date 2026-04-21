using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Spawns a Travelling Vendor at the calling player's position on the nearest ring road; registered as travellingvendor.spawn</summary>
/// <remarks>Full RCON name: <c>travellingvendor.spawn</c></remarks>
public sealed class TravellingvendorSpawnCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "travellingvendor.spawn";

    /// <summary>Creates a new <see cref="TravellingvendorSpawnCommand"/> command.</summary>
    public static TravellingvendorSpawnCommand Create()
    {
        var cmd = CreatePackage<TravellingvendorSpawnCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
