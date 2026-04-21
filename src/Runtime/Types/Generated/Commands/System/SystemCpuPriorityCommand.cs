using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Sets the OS process priority class (belownormal, normal, abovenormal, high); Idle and Realtime are blocked; not supported on OSX</summary>
/// <remarks>Full RCON name: <c>system.cpu_priority</c></remarks>
public sealed class SystemCpuPriorityCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "system.cpu_priority";

    /// <summary>Creates a new <see cref="SystemCpuPriorityCommand"/> command.</summary>
    public static SystemCpuPriorityCommand Create(string args)
    {
        var cmd = CreatePackage<SystemCpuPriorityCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
