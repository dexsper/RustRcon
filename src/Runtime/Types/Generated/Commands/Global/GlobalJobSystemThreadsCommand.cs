using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of Unity job worker threads; 0 or -1 sets the default (auto); higher values improve parallel job throughput on many-core CPUs</summary>
/// <remarks>Full RCON name: <c>global.job_system_threads</c></remarks>
public sealed class GlobalJobSystemThreadsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.job_system_threads";

    /// <summary>Reads the current value of <c>global.job_system_threads</c>.</summary>
    public static GlobalJobSystemThreadsCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalJobSystemThreadsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.job_system_threads</c> to <paramref name="value"/>.</summary>
    public static GlobalJobSystemThreadsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalJobSystemThreadsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
