using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Radius in metres around each player within which Christmas gift entities are spawned during the xmas event refill</summary>
/// <remarks>Full RCON name: <c>xmas.spawnrange</c></remarks>
public sealed class XmasSpawnrangeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "xmas.spawnrange";

    /// <summary>Reads the current value of <c>xmas.spawnrange</c>.</summary>
    public static XmasSpawnrangeCommand CreateGet()
    {
        var cmd = CreatePackage<XmasSpawnrangeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>xmas.spawnrange</c> to <paramref name="value"/>.</summary>
    public static XmasSpawnrangeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<XmasSpawnrangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
