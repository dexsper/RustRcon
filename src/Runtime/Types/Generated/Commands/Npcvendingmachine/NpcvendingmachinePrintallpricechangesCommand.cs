using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Print out all current price changes on the server</summary>
/// <remarks>Full RCON name: <c>npcvendingmachine.printallpricechanges</c></remarks>
public sealed class NpcvendingmachinePrintallpricechangesCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npcvendingmachine.printallpricechanges";

    /// <summary>Creates a new <see cref="NpcvendingmachinePrintallpricechangesCommand"/> command.</summary>
    public static NpcvendingmachinePrintallpricechangesCommand Create()
    {
        var cmd = CreatePackage<NpcvendingmachinePrintallpricechangesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
