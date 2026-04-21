using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server</summary>
/// <remarks>Full RCON name: <c>hotairballoon.population</c></remarks>
public sealed class HotairballoonPopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "hotairballoon.population";

    /// <summary>Reads the current value of <c>hotairballoon.population</c>.</summary>
    public static HotairballoonPopulationCommand CreateGet()
    {
        var cmd = CreatePackage<HotairballoonPopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>hotairballoon.population</c> to <paramref name="value"/>.</summary>
    public static HotairballoonPopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HotairballoonPopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
