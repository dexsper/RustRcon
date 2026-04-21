using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Upper cap on the loot container despawn multiplier; at default 24 the maximum lifetime is 24 x 5 min = 2 hours</summary>
/// <remarks>Full RCON name: <c>server.itemdespawn_container_max_multiplier</c></remarks>
public sealed class ServerItemdespawnContainerMaxMultiplierCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.itemdespawn_container_max_multiplier";

    /// <summary>Reads the current value of <c>server.itemdespawn_container_max_multiplier</c>.</summary>
    public static ServerItemdespawnContainerMaxMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<ServerItemdespawnContainerMaxMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.itemdespawn_container_max_multiplier</c> to <paramref name="value"/>.</summary>
    public static ServerItemdespawnContainerMaxMultiplierCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerItemdespawnContainerMaxMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
