using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Set to false to disable the storage adaptor sorting functionality</summary>
/// <remarks>Full RCON name: <c>server.allowsorting</c></remarks>
public sealed class ServerAllowsortingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.allowsorting";

    /// <summary>Reads the current value of <c>server.allowsorting</c>.</summary>
    public static ServerAllowsortingCommand CreateGet()
    {
        var cmd = CreatePackage<ServerAllowsortingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.allowsorting</c> to <paramref name="value"/>.</summary>
    public static ServerAllowsortingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerAllowsortingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
