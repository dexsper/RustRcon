using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the current time remaining until the deep sea wipe triggers as a formatted string; useful for monitoring wipe countdown during testing</summary>
/// <remarks>Full RCON name: <c>deepsea.printtimetowipe</c></remarks>
public sealed class DeepseaPrinttimetowipeCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.printtimetowipe";

    /// <summary>Creates a new <see cref="DeepseaPrinttimetowipeCommand"/> command.</summary>
    public static DeepseaPrinttimetowipeCommand Create()
    {
        var cmd = CreatePackage<DeepseaPrinttimetowipeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
