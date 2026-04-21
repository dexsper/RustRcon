using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server, per square km</summary>
/// <remarks>Full RCON name: <c>ridablehorse.population</c></remarks>
public sealed class RidablehorsePopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ridablehorse.population";

    /// <summary>Reads the current value of <c>ridablehorse.population</c>.</summary>
    public static RidablehorsePopulationCommand CreateGet()
    {
        var cmd = CreatePackage<RidablehorsePopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ridablehorse.population</c> to <paramref name="value"/>.</summary>
    public static RidablehorsePopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<RidablehorsePopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
