using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server, per square km</summary>
/// <remarks>Full RCON name: <c>boar.population</c></remarks>
public sealed class BoarPopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boar.population";

    /// <summary>Reads the current value of <c>boar.population</c>.</summary>
    public static BoarPopulationCommand CreateGet()
    {
        var cmd = CreatePackage<BoarPopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boar.population</c> to <paramref name="value"/>.</summary>
    public static BoarPopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BoarPopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
