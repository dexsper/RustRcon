using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>server.max_explosive_protection</c>.</summary>
/// <remarks>Full RCON name: <c>server.max_explosive_protection</c></remarks>
public sealed class ServerMaxExplosiveProtectionCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.max_explosive_protection";

    /// <summary>Reads the current value of <c>server.max_explosive_protection</c>.</summary>
    public static ServerMaxExplosiveProtectionCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxExplosiveProtectionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.max_explosive_protection</c> to <paramref name="value"/>.</summary>
    public static ServerMaxExplosiveProtectionCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerMaxExplosiveProtectionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
