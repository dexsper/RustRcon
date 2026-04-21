using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If a player presses the respawn button, respawn at their death location (for trailer filming)</summary>
/// <remarks>Full RCON name: <c>server.respawnatdeathposition</c></remarks>
public sealed class ServerRespawnatdeathpositionCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.respawnatdeathposition";

    /// <summary>Reads the current value of <c>server.respawnatdeathposition</c>.</summary>
    public static ServerRespawnatdeathpositionCommand CreateGet()
    {
        var cmd = CreatePackage<ServerRespawnatdeathpositionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.respawnatdeathposition</c> to <paramref name="value"/>.</summary>
    public static ServerRespawnatdeathpositionCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerRespawnatdeathpositionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
