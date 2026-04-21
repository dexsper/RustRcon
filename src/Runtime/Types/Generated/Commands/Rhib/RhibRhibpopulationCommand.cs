using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server</summary>
/// <remarks>Full RCON name: <c>rhib.rhibpopulation</c></remarks>
public sealed class RhibRhibpopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rhib.rhibpopulation";

    /// <summary>Reads the current value of <c>rhib.rhibpopulation</c>.</summary>
    public static RhibRhibpopulationCommand CreateGet()
    {
        var cmd = CreatePackage<RhibRhibpopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>rhib.rhibpopulation</c> to <paramref name="value"/>.</summary>
    public static RhibRhibpopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<RhibRhibpopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
