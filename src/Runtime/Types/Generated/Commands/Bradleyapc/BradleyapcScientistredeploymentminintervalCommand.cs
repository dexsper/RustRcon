using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>bradleyapc.scientistredeploymentmininterval</c>.</summary>
/// <remarks>Full RCON name: <c>bradleyapc.scientistredeploymentmininterval</c></remarks>
public sealed class BradleyapcScientistredeploymentminintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bradleyapc.scientistredeploymentmininterval";

    /// <summary>Reads the current value of <c>bradleyapc.scientistredeploymentmininterval</c>.</summary>
    public static BradleyapcScientistredeploymentminintervalCommand CreateGet()
    {
        var cmd = CreatePackage<BradleyapcScientistredeploymentminintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bradleyapc.scientistredeploymentmininterval</c> to <paramref name="value"/>.</summary>
    public static BradleyapcScientistredeploymentminintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BradleyapcScientistredeploymentminintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
