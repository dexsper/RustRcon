using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before a player helicopter loses all its health while indoors</summary>
/// <remarks>Full RCON name: <c>playerhelicopter.insidedecayminutes</c></remarks>
public sealed class PlayerhelicopterInsidedecayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerhelicopter.insidedecayminutes";

    /// <summary>Reads the current value of <c>playerhelicopter.insidedecayminutes</c>.</summary>
    public static PlayerhelicopterInsidedecayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerhelicopterInsidedecayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerhelicopter.insidedecayminutes</c> to <paramref name="value"/>.</summary>
    public static PlayerhelicopterInsidedecayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PlayerhelicopterInsidedecayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
