using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server, per square km</summary>
/// <remarks>Full RCON name: <c>crocodile.population</c></remarks>
public sealed class CrocodilePopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "crocodile.population";

    /// <summary>Reads the current value of <c>crocodile.population</c>.</summary>
    public static CrocodilePopulationCommand CreateGet()
    {
        var cmd = CreatePackage<CrocodilePopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>crocodile.population</c> to <paramref name="value"/>.</summary>
    public static CrocodilePopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<CrocodilePopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
