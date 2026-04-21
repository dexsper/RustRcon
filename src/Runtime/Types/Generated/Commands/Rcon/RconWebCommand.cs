using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If set to true, use websocket RCON. If set to false use legacy, source engine RCON. Source engine RCON is DEPRECATED</summary>
/// <remarks>Full RCON name: <c>rcon.web</c></remarks>
public sealed class RconWebCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.web";

    /// <summary>Reads the current value of <c>rcon.web</c>.</summary>
    public static RconWebCommand CreateGet()
    {
        var cmd = CreatePackage<RconWebCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>rcon.web</c> to <paramref name="value"/>.</summary>
    public static RconWebCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<RconWebCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
