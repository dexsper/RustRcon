using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>When transferring water, should containers keep 1 water behind. Enabling this should help performance if water IO is causing performance loss</summary>
/// <remarks>Full RCON name: <c>server.watercontainersleavewaterbehind</c></remarks>
public sealed class ServerWatercontainersleavewaterbehindCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.watercontainersleavewaterbehind";

    /// <summary>Reads the current value of <c>server.watercontainersleavewaterbehind</c>.</summary>
    public static ServerWatercontainersleavewaterbehindCommand CreateGet()
    {
        var cmd = CreatePackage<ServerWatercontainersleavewaterbehindCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.watercontainersleavewaterbehind</c> to <paramref name="value"/>.</summary>
    public static ServerWatercontainersleavewaterbehindCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerWatercontainersleavewaterbehindCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
