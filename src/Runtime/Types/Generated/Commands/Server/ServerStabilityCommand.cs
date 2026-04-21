using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables structural stability simulation; when disabled buildings will not collapse even if their supports are destroyed</summary>
/// <remarks>Full RCON name: <c>server.stability</c></remarks>
public sealed class ServerStabilityCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.stability";

    /// <summary>Reads the current value of <c>server.stability</c>.</summary>
    public static ServerStabilityCommand CreateGet()
    {
        var cmd = CreatePackage<ServerStabilityCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.stability</c> to <paramref name="value"/>.</summary>
    public static ServerStabilityCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerStabilityCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
