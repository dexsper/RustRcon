using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server, per square km</summary>
/// <remarks>Full RCON name: <c>wolf.population</c></remarks>
public sealed class WolfPopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "wolf.population";

    /// <summary>Reads the current value of <c>wolf.population</c>.</summary>
    public static WolfPopulationCommand CreateGet()
    {
        var cmd = CreatePackage<WolfPopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>wolf.population</c> to <paramref name="value"/>.</summary>
    public static WolfPopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WolfPopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
