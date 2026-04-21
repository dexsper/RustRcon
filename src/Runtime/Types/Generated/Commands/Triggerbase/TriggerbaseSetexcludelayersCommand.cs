using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Applies the configured exclude layer mask to all registered TriggerBase instances to filter out unwanted layer detections</summary>
/// <remarks>Full RCON name: <c>triggerbase.setexcludelayers</c></remarks>
public sealed class TriggerbaseSetexcludelayersCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "triggerbase.setexcludelayers";

    /// <summary>Creates a new <see cref="TriggerbaseSetexcludelayersCommand"/> command.</summary>
    public static TriggerbaseSetexcludelayersCommand Create()
    {
        var cmd = CreatePackage<TriggerbaseSetexcludelayersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
