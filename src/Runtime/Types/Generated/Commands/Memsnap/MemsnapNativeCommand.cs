using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Takes a Unity Memory Profiler snapshot capturing native (C++) heap allocations and saves it as a timestamped .snap file in the profile/ folder</summary>
/// <remarks>Full RCON name: <c>memsnap.native</c></remarks>
public sealed class MemsnapNativeCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "memsnap.native";

    /// <summary>Creates a new <see cref="MemsnapNativeCommand"/> command.</summary>
    public static MemsnapNativeCommand Create()
    {
        var cmd = CreatePackage<MemsnapNativeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
