using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Sets the time in seconds until the deep sea wipe triggers; pass 0 to trigger immediately; useful for testing the wipe sequence without waiting</summary>
/// <remarks>Full RCON name: <c>deepsea.settimetowipe</c></remarks>
public sealed class DeepseaSettimetowipeCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.settimetowipe";

    /// <summary>Creates a new <see cref="DeepseaSettimetowipeCommand"/> command.</summary>
    public static DeepseaSettimetowipeCommand Create(float value)
    {
        var cmd = CreatePackage<DeepseaSettimetowipeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
