using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables per-player required system configuration checks on connect; allows different requirements to be enforced for individual players</summary>
/// <remarks>Full RCON name: <c>server.useperplayerrequiredsystemconfig</c></remarks>
public sealed class ServerUseperplayerrequiredsystemconfigCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.useperplayerrequiredsystemconfig";

    /// <summary>Reads the current value of <c>server.useperplayerrequiredsystemconfig</c>.</summary>
    public static ServerUseperplayerrequiredsystemconfigCommand CreateGet()
    {
        var cmd = CreatePackage<ServerUseperplayerrequiredsystemconfigCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.useperplayerrequiredsystemconfig</c> to <paramref name="value"/>.</summary>
    public static ServerUseperplayerrequiredsystemconfigCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerUseperplayerrequiredsystemconfigCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
