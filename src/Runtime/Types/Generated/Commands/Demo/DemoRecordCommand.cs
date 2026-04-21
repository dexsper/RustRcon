using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Starts recording a server-side demo for the specified player by name or Steam ID to a timestamped file; the player must be connected</summary>
/// <remarks>Full RCON name: <c>demo.record</c></remarks>
public sealed class DemoRecordCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.record";

    /// <summary>Creates a new <see cref="DemoRecordCommand"/> command.</summary>
    public static DemoRecordCommand Create()
    {
        var cmd = CreatePackage<DemoRecordCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
