using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server, per square km</summary>
/// <remarks>Full RCON name: <c>polarbear.population</c></remarks>
public sealed class PolarbearPopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "polarbear.population";

    /// <summary>Reads the current value of <c>polarbear.population</c>.</summary>
    public static PolarbearPopulationCommand CreateGet()
    {
        var cmd = CreatePackage<PolarbearPopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>polarbear.population</c> to <paramref name="value"/>.</summary>
    public static PolarbearPopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PolarbearPopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
