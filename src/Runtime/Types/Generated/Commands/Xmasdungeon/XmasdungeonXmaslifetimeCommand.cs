using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long each active dungeon should last before dying</summary>
/// <remarks>Full RCON name: <c>xmasdungeon.xmaslifetime</c></remarks>
public sealed class XmasdungeonXmaslifetimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "xmasdungeon.xmaslifetime";

    /// <summary>Reads the current value of <c>xmasdungeon.xmaslifetime</c>.</summary>
    public static XmasdungeonXmaslifetimeCommand CreateGet()
    {
        var cmd = CreatePackage<XmasdungeonXmaslifetimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>xmasdungeon.xmaslifetime</c> to <paramref name="value"/>.</summary>
    public static XmasdungeonXmaslifetimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<XmasdungeonXmaslifetimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
