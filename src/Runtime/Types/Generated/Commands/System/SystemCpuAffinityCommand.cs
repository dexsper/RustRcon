using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Sets the CPU core affinity mask for the process using comma-separated core indices or dash-separated ranges (e.g. 0,2-5)</summary>
/// <remarks>Full RCON name: <c>system.cpu_affinity</c></remarks>
public sealed class SystemCpuAffinityCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "system.cpu_affinity";

    /// <summary>Creates a new <see cref="SystemCpuAffinityCommand"/> command.</summary>
    public static SystemCpuAffinityCommand Create(string array)
    {
        var cmd = CreatePackage<SystemCpuAffinityCommand>();
        cmd.Content = $"{CommandFullName} {array}";
        return cmd;
    }
}
