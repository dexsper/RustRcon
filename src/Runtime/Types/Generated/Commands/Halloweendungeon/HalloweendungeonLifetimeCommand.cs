using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long each active dungeon should last before dying</summary>
/// <remarks>Full RCON name: <c>halloweendungeon.lifetime</c></remarks>
public sealed class HalloweendungeonLifetimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "halloweendungeon.lifetime";

    /// <summary>Reads the current value of <c>halloweendungeon.lifetime</c>.</summary>
    public static HalloweendungeonLifetimeCommand CreateGet()
    {
        var cmd = CreatePackage<HalloweendungeonLifetimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>halloweendungeon.lifetime</c> to <paramref name="value"/>.</summary>
    public static HalloweendungeonLifetimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HalloweendungeonLifetimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
