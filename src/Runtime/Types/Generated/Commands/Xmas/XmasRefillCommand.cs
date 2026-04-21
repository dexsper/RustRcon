using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Manually triggers a Christmas gift spawn pass, filling the world with gifts up to the giftsPerPlayer target for all connected players</summary>
/// <remarks>Full RCON name: <c>xmas.refill</c></remarks>
public sealed class XmasRefillCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "xmas.refill";

    /// <summary>Creates a new <see cref="XmasRefillCommand"/> command.</summary>
    public static XmasRefillCommand Create()
    {
        var cmd = CreatePackage<XmasRefillCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
