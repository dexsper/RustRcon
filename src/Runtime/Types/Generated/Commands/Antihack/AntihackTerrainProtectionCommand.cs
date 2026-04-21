using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.terrain_protection</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.terrain_protection</c></remarks>
public sealed class AntihackTerrainProtectionCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.terrain_protection";

    /// <summary>Reads the current value of <c>antihack.terrain_protection</c>.</summary>
    public static AntihackTerrainProtectionCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackTerrainProtectionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.terrain_protection</c> to <paramref name="value"/>.</summary>
    public static AntihackTerrainProtectionCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackTerrainProtectionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
