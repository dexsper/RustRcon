using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Fire all catapults</summary>
/// <remarks>Full RCON name: <c>catapult.fire</c></remarks>
public sealed class CatapultFireCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "catapult.fire";

    /// <summary>Creates a new <see cref="CatapultFireCommand"/> command.</summary>
    public static CatapultFireCommand Create()
    {
        var cmd = CreatePackage<CatapultFireCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
