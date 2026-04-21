using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Removes the exclude layer configuration from all registered TriggerBase instances, resetting them to detect all layers</summary>
/// <remarks>Full RCON name: <c>triggerbase.clearexcludelayers</c></remarks>
public sealed class TriggerbaseClearexcludelayersCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "triggerbase.clearexcludelayers";

    /// <summary>Creates a new <see cref="TriggerbaseClearexcludelayersCommand"/> command.</summary>
    public static TriggerbaseClearexcludelayersCommand Create()
    {
        var cmd = CreatePackage<TriggerbaseClearexcludelayersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
