using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server, per square km</summary>
/// <remarks>Full RCON name: <c>stag.population</c></remarks>
public sealed class StagPopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "stag.population";

    /// <summary>Reads the current value of <c>stag.population</c>.</summary>
    public static StagPopulationCommand CreateGet()
    {
        var cmd = CreatePackage<StagPopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>stag.population</c> to <paramref name="value"/>.</summary>
    public static StagPopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<StagPopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
