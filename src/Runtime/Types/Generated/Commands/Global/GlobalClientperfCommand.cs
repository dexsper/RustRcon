using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Requests a performance report from every connected client; supports legacy and JSON formats; used for monitoring client frame rates and memory usage</summary>
/// <remarks>Full RCON name: <c>global.clientperf</c></remarks>
public sealed class GlobalClientperfCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.clientperf";

    /// <summary>Creates a new <see cref="GlobalClientperfCommand"/> command.</summary>
    public static GlobalClientperfCommand Create(string arg0, int arg1)
    {
        var cmd = CreatePackage<GlobalClientperfCommand>();
        cmd.Content = $"{CommandFullName} {arg0} {arg1}";
        return cmd;
    }
}
