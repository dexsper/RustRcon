using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of entities included in each entity-update batch per frame; tune to balance CPU time spent on entity processing</summary>
/// <remarks>Full RCON name: <c>server.entitybatchsize</c></remarks>
public sealed class ServerEntitybatchsizeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.entitybatchsize";

    /// <summary>Reads the current value of <c>server.entitybatchsize</c>.</summary>
    public static ServerEntitybatchsizeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerEntitybatchsizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.entitybatchsize</c> to <paramref name="value"/>.</summary>
    public static ServerEntitybatchsizeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerEntitybatchsizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
