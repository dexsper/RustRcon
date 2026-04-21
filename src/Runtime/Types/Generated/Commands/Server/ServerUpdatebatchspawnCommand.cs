using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of entities processed per batch during the initial spawn network update; higher values send more entities per frame during map load</summary>
/// <remarks>Full RCON name: <c>server.updatebatchspawn</c></remarks>
public sealed class ServerUpdatebatchspawnCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.updatebatchspawn";

    /// <summary>Reads the current value of <c>server.updatebatchspawn</c>.</summary>
    public static ServerUpdatebatchspawnCommand CreateGet()
    {
        var cmd = CreatePackage<ServerUpdatebatchspawnCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.updatebatchspawn</c> to <paramref name="value"/>.</summary>
    public static ServerUpdatebatchspawnCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerUpdatebatchspawnCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
