using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, debug spheres are drawn in the world showing the radiation zone boundaries during monument puzzle resets</summary>
/// <remarks>Full RCON name: <c>server.drawpuzzleresets</c></remarks>
public sealed class ServerDrawpuzzleresetsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.drawpuzzleresets";

    /// <summary>Reads the current value of <c>server.drawpuzzleresets</c>.</summary>
    public static ServerDrawpuzzleresetsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerDrawpuzzleresetsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.drawpuzzleresets</c> to <paramref name="value"/>.</summary>
    public static ServerDrawpuzzleresetsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerDrawpuzzleresetsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
