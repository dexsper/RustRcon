using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>UsePlayerUpdateJobs 2 related - how many snapshot messages to batch into 1 task</summary>
/// <remarks>Full RCON name: <c>server.snapshottaskbatchcount</c></remarks>
public sealed class ServerSnapshottaskbatchcountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.snapshottaskbatchcount";

    /// <summary>Reads the current value of <c>server.snapshottaskbatchcount</c>.</summary>
    public static ServerSnapshottaskbatchcountCommand CreateGet()
    {
        var cmd = CreatePackage<ServerSnapshottaskbatchcountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.snapshottaskbatchcount</c> to <paramref name="value"/>.</summary>
    public static ServerSnapshottaskbatchcountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerSnapshottaskbatchcountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
