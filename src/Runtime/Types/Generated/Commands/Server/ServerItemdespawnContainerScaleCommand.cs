using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Multiplier applied to the base item despawn time for items sitting inside loot containers; default 2x extends their lifetime</summary>
/// <remarks>Full RCON name: <c>server.itemdespawn_container_scale</c></remarks>
public sealed class ServerItemdespawnContainerScaleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.itemdespawn_container_scale";

    /// <summary>Reads the current value of <c>server.itemdespawn_container_scale</c>.</summary>
    public static ServerItemdespawnContainerScaleCommand CreateGet()
    {
        var cmd = CreatePackage<ServerItemdespawnContainerScaleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.itemdespawn_container_scale</c> to <paramref name="value"/>.</summary>
    public static ServerItemdespawnContainerScaleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerItemdespawnContainerScaleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
