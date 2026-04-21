using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Whether or not to send additional analytics to EAC</summary>
/// <remarks>Full RCON name: <c>server.eac_gameplay_data</c></remarks>
public sealed class ServerEacGameplayDataCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.eac_gameplay_data";

    /// <summary>Reads the current value of <c>server.eac_gameplay_data</c>.</summary>
    public static ServerEacGameplayDataCommand CreateGet()
    {
        var cmd = CreatePackage<ServerEacGameplayDataCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.eac_gameplay_data</c> to <paramref name="value"/>.</summary>
    public static ServerEacGameplayDataCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerEacGameplayDataCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
