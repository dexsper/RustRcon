using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before a boat loses all its health while outside</summary>
/// <remarks>Full RCON name: <c>playerboat.decayminutes</c></remarks>
public sealed class PlayerboatDecayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.decayminutes";

    /// <summary>Reads the current value of <c>playerboat.decayminutes</c>.</summary>
    public static PlayerboatDecayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatDecayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.decayminutes</c> to <paramref name="value"/>.</summary>
    public static PlayerboatDecayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PlayerboatDecayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
