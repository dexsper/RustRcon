using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints drag force debug data based on the angle between the boat heading and player look direction; admin-only</summary>
/// <remarks>Full RCON name: <c>playerboat.lookatdragbyangle</c></remarks>
public sealed class PlayerboatLookatdragbyangleCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.lookatdragbyangle";

    /// <summary>Creates a new <see cref="PlayerboatLookatdragbyangleCommand"/> command.</summary>
    public static PlayerboatLookatdragbyangleCommand Create()
    {
        var cmd = CreatePackage<PlayerboatLookatdragbyangleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
