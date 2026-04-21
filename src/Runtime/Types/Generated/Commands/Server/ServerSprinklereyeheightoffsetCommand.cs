using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Vertical eye-height offset in metres used when raycasting to determine whether a sprinkler can water a given plant</summary>
/// <remarks>Full RCON name: <c>server.sprinklereyeheightoffset</c></remarks>
public sealed class ServerSprinklereyeheightoffsetCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.sprinklereyeheightoffset";

    /// <summary>Reads the current value of <c>server.sprinklereyeheightoffset</c>.</summary>
    public static ServerSprinklereyeheightoffsetCommand CreateGet()
    {
        var cmd = CreatePackage<ServerSprinklereyeheightoffsetCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.sprinklereyeheightoffset</c> to <paramref name="value"/>.</summary>
    public static ServerSprinklereyeheightoffsetCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerSprinklereyeheightoffsetCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
