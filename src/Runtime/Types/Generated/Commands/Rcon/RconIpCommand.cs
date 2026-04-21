using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>IP Address to listen for RCON connections</summary>
/// <remarks>Full RCON name: <c>rcon.ip</c></remarks>
public sealed class RconIpCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.ip";

    /// <summary>Reads the current value of <c>rcon.ip</c>.</summary>
    public static RconIpCommand CreateGet()
    {
        var cmd = CreatePackage<RconIpCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>rcon.ip</c> to <paramref name="value"/>.</summary>
    public static RconIpCommand CreateSet(string value)
    {
        var cmd = CreatePackage<RconIpCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
