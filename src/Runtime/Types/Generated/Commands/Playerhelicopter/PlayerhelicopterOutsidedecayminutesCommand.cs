using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before a player helicopter loses all its health while outside</summary>
/// <remarks>Full RCON name: <c>playerhelicopter.outsidedecayminutes</c></remarks>
public sealed class PlayerhelicopterOutsidedecayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerhelicopter.outsidedecayminutes";

    /// <summary>Reads the current value of <c>playerhelicopter.outsidedecayminutes</c>.</summary>
    public static PlayerhelicopterOutsidedecayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerhelicopterOutsidedecayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerhelicopter.outsidedecayminutes</c> to <paramref name="value"/>.</summary>
    public static PlayerhelicopterOutsidedecayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PlayerhelicopterOutsidedecayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
