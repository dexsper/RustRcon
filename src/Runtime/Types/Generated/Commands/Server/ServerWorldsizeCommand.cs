using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Width and height of the procedurally generated world in metres; larger values create a bigger map with more resources</summary>
/// <remarks>Full RCON name: <c>server.worldsize</c></remarks>
public sealed class ServerWorldsizeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.worldsize";

    /// <summary>Reads the current value of <c>server.worldsize</c>.</summary>
    public static ServerWorldsizeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerWorldsizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.worldsize</c> to <paramref name="value"/>.</summary>
    public static ServerWorldsizeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerWorldsizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
