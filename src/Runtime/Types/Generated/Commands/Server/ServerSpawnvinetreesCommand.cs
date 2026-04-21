using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When true, vine tree variants are included during world generation; disable to remove all climbable vine trees from the map</summary>
/// <remarks>Full RCON name: <c>server.spawnvinetrees</c></remarks>
public sealed class ServerSpawnvinetreesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.spawnvinetrees";

    /// <summary>Reads the current value of <c>server.spawnvinetrees</c>.</summary>
    public static ServerSpawnvinetreesCommand CreateGet()
    {
        var cmd = CreatePackage<ServerSpawnvinetreesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.spawnvinetrees</c> to <paramref name="value"/>.</summary>
    public static ServerSpawnvinetreesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerSpawnvinetreesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
