using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Network encryption mode; 2 = enabled (recommended), 0 = disabled</summary>
/// <remarks>Full RCON name: <c>server.encryption</c></remarks>
public sealed class ServerEncryptionCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.encryption";

    /// <summary>Reads the current value of <c>server.encryption</c>.</summary>
    public static ServerEncryptionCommand CreateGet()
    {
        var cmd = CreatePackage<ServerEncryptionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.encryption</c> to <paramref name="value"/>.</summary>
    public static ServerEncryptionCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerEncryptionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
