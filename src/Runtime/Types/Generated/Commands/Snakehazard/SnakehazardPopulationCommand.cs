using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server, per square km</summary>
/// <remarks>Full RCON name: <c>snakehazard.population</c></remarks>
public sealed class SnakehazardPopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "snakehazard.population";

    /// <summary>Reads the current value of <c>snakehazard.population</c>.</summary>
    public static SnakehazardPopulationCommand CreateGet()
    {
        var cmd = CreatePackage<SnakehazardPopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>snakehazard.population</c> to <paramref name="value"/>.</summary>
    public static SnakehazardPopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SnakehazardPopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
