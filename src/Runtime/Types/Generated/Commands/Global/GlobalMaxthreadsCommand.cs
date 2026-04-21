using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of Unity job system worker threads; controls the background thread pool size for job dispatching</summary>
/// <remarks>Full RCON name: <c>global.maxthreads</c></remarks>
public sealed class GlobalMaxthreadsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.maxthreads";

    /// <summary>Reads the current value of <c>global.maxthreads</c>.</summary>
    public static GlobalMaxthreadsCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalMaxthreadsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.maxthreads</c> to <paramref name="value"/>.</summary>
    public static GlobalMaxthreadsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalMaxthreadsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
