using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>MS per frame to spend warming up entity save caches</summary>
/// <remarks>Full RCON name: <c>server.saveframebudget</c></remarks>
public sealed class ServerSaveframebudgetCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.saveframebudget";

    /// <summary>Reads the current value of <c>server.saveframebudget</c>.</summary>
    public static ServerSaveframebudgetCommand CreateGet()
    {
        var cmd = CreatePackage<ServerSaveframebudgetCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.saveframebudget</c> to <paramref name="value"/>.</summary>
    public static ServerSaveframebudgetCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerSaveframebudgetCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
