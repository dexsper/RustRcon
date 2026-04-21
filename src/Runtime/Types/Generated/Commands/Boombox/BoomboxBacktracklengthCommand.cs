using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of seconds of audio backtrack buffer maintained by the boombox for streaming synchronisation; default 30s</summary>
/// <remarks>Full RCON name: <c>boombox.backtracklength</c></remarks>
public sealed class BoomboxBacktracklengthCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boombox.backtracklength";

    /// <summary>Reads the current value of <c>boombox.backtracklength</c>.</summary>
    public static BoomboxBacktracklengthCommand CreateGet()
    {
        var cmd = CreatePackage<BoomboxBacktracklengthCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boombox.backtracklength</c> to <paramref name="value"/>.</summary>
    public static BoomboxBacktracklengthCommand CreateSet(int value)
    {
        var cmd = CreatePackage<BoomboxBacktracklengthCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
