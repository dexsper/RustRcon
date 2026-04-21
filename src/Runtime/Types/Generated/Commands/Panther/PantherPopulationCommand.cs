using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server, per square km</summary>
/// <remarks>Full RCON name: <c>panther.population</c></remarks>
public sealed class PantherPopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "panther.population";

    /// <summary>Reads the current value of <c>panther.population</c>.</summary>
    public static PantherPopulationCommand CreateGet()
    {
        var cmd = CreatePackage<PantherPopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>panther.population</c> to <paramref name="value"/>.</summary>
    public static PantherPopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PantherPopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
