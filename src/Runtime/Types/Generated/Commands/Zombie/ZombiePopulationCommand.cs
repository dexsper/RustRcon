using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server, per square km</summary>
/// <remarks>Full RCON name: <c>zombie.population</c></remarks>
public sealed class ZombiePopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "zombie.population";

    /// <summary>Reads the current value of <c>zombie.population</c>.</summary>
    public static ZombiePopulationCommand CreateGet()
    {
        var cmd = CreatePackage<ZombiePopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>zombie.population</c> to <paramref name="value"/>.</summary>
    public static ZombiePopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ZombiePopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
