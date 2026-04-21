using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of entities processed per network update batch; lower values spread the load across more frames but increase total overhead</summary>
/// <remarks>Full RCON name: <c>server.updatebatch</c></remarks>
public sealed class ServerUpdatebatchCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.updatebatch";

    /// <summary>Reads the current value of <c>server.updatebatch</c>.</summary>
    public static ServerUpdatebatchCommand CreateGet()
    {
        var cmd = CreatePackage<ServerUpdatebatchCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.updatebatch</c> to <paramref name="value"/>.</summary>
    public static ServerUpdatebatchCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerUpdatebatchCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
