using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>UsePlayerUpdateJobs 2 related - how many destroy messages to batch into 1 task</summary>
/// <remarks>Full RCON name: <c>server.destroytaskbatchcount</c></remarks>
public sealed class ServerDestroytaskbatchcountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.destroytaskbatchcount";

    /// <summary>Reads the current value of <c>server.destroytaskbatchcount</c>.</summary>
    public static ServerDestroytaskbatchcountCommand CreateGet()
    {
        var cmd = CreatePackage<ServerDestroytaskbatchcountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.destroytaskbatchcount</c> to <paramref name="value"/>.</summary>
    public static ServerDestroytaskbatchcountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerDestroytaskbatchcountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
