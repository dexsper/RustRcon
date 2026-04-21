using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Toggles the locked state of the handcuffs held by the calling admin player, switching between locked and unlocked</summary>
/// <remarks>Full RCON name: <c>handcuffs.togglecuffslocked</c></remarks>
public sealed class HandcuffsTogglecuffslockedCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "handcuffs.togglecuffslocked";

    /// <summary>Creates a new <see cref="HandcuffsTogglecuffslockedCommand"/> command.</summary>
    public static HandcuffsTogglecuffslockedCommand Create()
    {
        var cmd = CreatePackage<HandcuffsTogglecuffslockedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
