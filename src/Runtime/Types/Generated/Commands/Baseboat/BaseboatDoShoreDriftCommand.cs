using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, boats without nearby players will slowly drift toward the shore after the shore drift delay elapses</summary>
/// <remarks>Full RCON name: <c>baseboat.do_shore_drift</c></remarks>
public sealed class BaseboatDoShoreDriftCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "baseboat.do_shore_drift";

    /// <summary>Reads the current value of <c>baseboat.do_shore_drift</c>.</summary>
    public static BaseboatDoShoreDriftCommand CreateGet()
    {
        var cmd = CreatePackage<BaseboatDoShoreDriftCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>baseboat.do_shore_drift</c> to <paramref name="value"/>.</summary>
    public static BaseboatDoShoreDriftCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BaseboatDoShoreDriftCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
