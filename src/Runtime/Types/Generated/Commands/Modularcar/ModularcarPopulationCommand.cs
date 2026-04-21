using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server</summary>
/// <remarks>Full RCON name: <c>modularcar.population</c></remarks>
public sealed class ModularcarPopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "modularcar.population";

    /// <summary>Reads the current value of <c>modularcar.population</c>.</summary>
    public static ModularcarPopulationCommand CreateGet()
    {
        var cmd = CreatePackage<ModularcarPopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>modularcar.population</c> to <paramref name="value"/>.</summary>
    public static ModularcarPopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ModularcarPopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
