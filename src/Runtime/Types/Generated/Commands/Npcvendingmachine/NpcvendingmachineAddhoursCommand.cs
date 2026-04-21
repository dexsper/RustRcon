using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Simulates the provided number of hours passing in the vending machine system</summary>
/// <remarks>Full RCON name: <c>npcvendingmachine.addhours</c></remarks>
public sealed class NpcvendingmachineAddhoursCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npcvendingmachine.addhours";

    /// <summary>Creates a new <see cref="NpcvendingmachineAddhoursCommand"/> command.</summary>
    public static NpcvendingmachineAddhoursCommand Create()
    {
        var cmd = CreatePackage<NpcvendingmachineAddhoursCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
