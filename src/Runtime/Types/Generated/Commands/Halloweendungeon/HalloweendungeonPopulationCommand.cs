using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server</summary>
/// <remarks>Full RCON name: <c>halloweendungeon.population</c></remarks>
public sealed class HalloweendungeonPopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "halloweendungeon.population";

    /// <summary>Reads the current value of <c>halloweendungeon.population</c>.</summary>
    public static HalloweendungeonPopulationCommand CreateGet()
    {
        var cmd = CreatePackage<HalloweendungeonPopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>halloweendungeon.population</c> to <paramref name="value"/>.</summary>
    public static HalloweendungeonPopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HalloweendungeonPopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
