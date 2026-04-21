using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>npcvendingmachine.resetfrequencytags</c>.</summary>
/// <remarks>Full RCON name: <c>npcvendingmachine.resetfrequencytags</c></remarks>
public sealed class NpcvendingmachineResetfrequencytagsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npcvendingmachine.resetfrequencytags";

    /// <summary>Creates a new <see cref="NpcvendingmachineResetfrequencytagsCommand"/> command.</summary>
    public static NpcvendingmachineResetfrequencytagsCommand Create()
    {
        var cmd = CreatePackage<NpcvendingmachineResetfrequencytagsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
