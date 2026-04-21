using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server, per square km</summary>
/// <remarks>Full RCON name: <c>chicken.population</c></remarks>
public sealed class ChickenPopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "chicken.population";

    /// <summary>Reads the current value of <c>chicken.population</c>.</summary>
    public static ChickenPopulationCommand CreateGet()
    {
        var cmd = CreatePackage<ChickenPopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>chicken.population</c> to <paramref name="value"/>.</summary>
    public static ChickenPopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ChickenPopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
