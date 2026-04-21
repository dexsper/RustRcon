using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Sets the breed index of the horse directly in front of the calling admin player to the given integer value</summary>
/// <remarks>Full RCON name: <c>ridablehorse.sethorsebreed</c></remarks>
public sealed class RidablehorseSethorsebreedCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ridablehorse.sethorsebreed";

    /// <summary>Creates a new <see cref="RidablehorseSethorsebreedCommand"/> command.</summary>
    public static RidablehorseSethorsebreedCommand Create()
    {
        var cmd = CreatePackage<RidablehorseSethorsebreedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
