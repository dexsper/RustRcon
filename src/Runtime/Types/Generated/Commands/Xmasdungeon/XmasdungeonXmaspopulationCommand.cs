using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server</summary>
/// <remarks>Full RCON name: <c>xmasdungeon.xmaspopulation</c></remarks>
public sealed class XmasdungeonXmaspopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "xmasdungeon.xmaspopulation";

    /// <summary>Reads the current value of <c>xmasdungeon.xmaspopulation</c>.</summary>
    public static XmasdungeonXmaspopulationCommand CreateGet()
    {
        var cmd = CreatePackage<XmasdungeonXmaspopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>xmasdungeon.xmaspopulation</c> to <paramref name="value"/>.</summary>
    public static XmasdungeonXmaspopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<XmasdungeonXmaspopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
