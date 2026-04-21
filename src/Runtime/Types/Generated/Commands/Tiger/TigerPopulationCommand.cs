using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server, per square km</summary>
/// <remarks>Full RCON name: <c>tiger.population</c></remarks>
public sealed class TigerPopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "tiger.population";

    /// <summary>Reads the current value of <c>tiger.population</c>.</summary>
    public static TigerPopulationCommand CreateGet()
    {
        var cmd = CreatePackage<TigerPopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>tiger.population</c> to <paramref name="value"/>.</summary>
    public static TigerPopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TigerPopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
