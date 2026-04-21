using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server</summary>
/// <remarks>Full RCON name: <c>scraptransporthelicopter.population</c></remarks>
public sealed class ScraptransporthelicopterPopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "scraptransporthelicopter.population";

    /// <summary>Reads the current value of <c>scraptransporthelicopter.population</c>.</summary>
    public static ScraptransporthelicopterPopulationCommand CreateGet()
    {
        var cmd = CreatePackage<ScraptransporthelicopterPopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>scraptransporthelicopter.population</c> to <paramref name="value"/>.</summary>
    public static ScraptransporthelicopterPopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ScraptransporthelicopterPopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
