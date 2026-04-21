using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server, per square km</summary>
/// <remarks>Full RCON name: <c>metaldetectorsource.population</c></remarks>
public sealed class MetaldetectorsourcePopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "metaldetectorsource.population";

    /// <summary>Reads the current value of <c>metaldetectorsource.population</c>.</summary>
    public static MetaldetectorsourcePopulationCommand CreateGet()
    {
        var cmd = CreatePackage<MetaldetectorsourcePopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>metaldetectorsource.population</c> to <paramref name="value"/>.</summary>
    public static MetaldetectorsourcePopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<MetaldetectorsourcePopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
