using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server</summary>
/// <remarks>Full RCON name: <c>minicopter.population</c></remarks>
public sealed class MinicopterPopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "minicopter.population";

    /// <summary>Reads the current value of <c>minicopter.population</c>.</summary>
    public static MinicopterPopulationCommand CreateGet()
    {
        var cmd = CreatePackage<MinicopterPopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>minicopter.population</c> to <paramref name="value"/>.</summary>
    public static MinicopterPopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<MinicopterPopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
