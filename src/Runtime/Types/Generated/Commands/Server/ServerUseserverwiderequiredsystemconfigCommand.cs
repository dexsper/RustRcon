using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables a server-wide required system configuration that all connecting clients must satisfy; used to enforce minimum hardware or software requirements</summary>
/// <remarks>Full RCON name: <c>server.useserverwiderequiredsystemconfig</c></remarks>
public sealed class ServerUseserverwiderequiredsystemconfigCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.useserverwiderequiredsystemconfig";

    /// <summary>Reads the current value of <c>server.useserverwiderequiredsystemconfig</c>.</summary>
    public static ServerUseserverwiderequiredsystemconfigCommand CreateGet()
    {
        var cmd = CreatePackage<ServerUseserverwiderequiredsystemconfigCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.useserverwiderequiredsystemconfig</c> to <paramref name="value"/>.</summary>
    public static ServerUseserverwiderequiredsystemconfigCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerUseserverwiderequiredsystemconfigCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
