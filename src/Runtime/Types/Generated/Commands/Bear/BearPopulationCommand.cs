using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server, per square km</summary>
/// <remarks>Full RCON name: <c>bear.population</c></remarks>
public sealed class BearPopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bear.population";

    /// <summary>Reads the current value of <c>bear.population</c>.</summary>
    public static BearPopulationCommand CreateGet()
    {
        var cmd = CreatePackage<BearPopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bear.population</c> to <paramref name="value"/>.</summary>
    public static BearPopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BearPopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
