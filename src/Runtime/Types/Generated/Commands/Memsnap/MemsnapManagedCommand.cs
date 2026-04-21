using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Takes a Unity Memory Profiler snapshot capturing managed (C#) heap allocations and saves it as a timestamped .snap file in the profile/ folder</summary>
/// <remarks>Full RCON name: <c>memsnap.managed</c></remarks>
public sealed class MemsnapManagedCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "memsnap.managed";

    /// <summary>Creates a new <see cref="MemsnapManagedCommand"/> command.</summary>
    public static MemsnapManagedCommand Create()
    {
        var cmd = CreatePackage<MemsnapManagedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
