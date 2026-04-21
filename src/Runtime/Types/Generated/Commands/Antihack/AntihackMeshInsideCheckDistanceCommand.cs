using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.mesh_inside_check_distance</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.mesh_inside_check_distance</c></remarks>
public sealed class AntihackMeshInsideCheckDistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.mesh_inside_check_distance";

    /// <summary>Reads the current value of <c>antihack.mesh_inside_check_distance</c>.</summary>
    public static AntihackMeshInsideCheckDistanceCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackMeshInsideCheckDistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.mesh_inside_check_distance</c> to <paramref name="value"/>.</summary>
    public static AntihackMeshInsideCheckDistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackMeshInsideCheckDistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
