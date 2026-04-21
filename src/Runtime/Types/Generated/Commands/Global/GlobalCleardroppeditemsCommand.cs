using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Removes all dropped item entities from the server, cleaning up every piece of loot on the ground</summary>
/// <remarks>Full RCON name: <c>global.cleardroppeditems</c></remarks>
public sealed class GlobalCleardroppeditemsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.cleardroppeditems";

    /// <summary>Creates a new <see cref="GlobalCleardroppeditemsCommand"/> command.</summary>
    public static GlobalCleardroppeditemsCommand Create()
    {
        var cmd = CreatePackage<GlobalCleardroppeditemsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
