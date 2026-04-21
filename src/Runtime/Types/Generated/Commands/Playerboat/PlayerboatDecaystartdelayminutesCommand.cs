using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long until decay begins after the boat was last used</summary>
/// <remarks>Full RCON name: <c>playerboat.decaystartdelayminutes</c></remarks>
public sealed class PlayerboatDecaystartdelayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.decaystartdelayminutes";

    /// <summary>Reads the current value of <c>playerboat.decaystartdelayminutes</c>.</summary>
    public static PlayerboatDecaystartdelayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatDecaystartdelayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.decaystartdelayminutes</c> to <paramref name="value"/>.</summary>
    public static PlayerboatDecaystartdelayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PlayerboatDecaystartdelayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
