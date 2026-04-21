using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Ragdolls the ridable horse entity directly in front of the calling admin player; useful for testing horse physics and death states</summary>
/// <remarks>Full RCON name: <c>ridablehorse.ragdoll</c></remarks>
public sealed class RidablehorseRagdollCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ridablehorse.ragdoll";

    /// <summary>Creates a new <see cref="RidablehorseRagdollCommand"/> command.</summary>
    public static RidablehorseRagdollCommand Create()
    {
        var cmd = CreatePackage<RidablehorseRagdollCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
