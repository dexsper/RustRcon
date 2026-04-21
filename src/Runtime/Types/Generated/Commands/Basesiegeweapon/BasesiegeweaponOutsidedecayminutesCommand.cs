using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many minutes before a siege weapon loses all its health while outside</summary>
/// <remarks>Full RCON name: <c>basesiegeweapon.outsidedecayminutes</c></remarks>
public sealed class BasesiegeweaponOutsidedecayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basesiegeweapon.outsidedecayminutes";

    /// <summary>Reads the current value of <c>basesiegeweapon.outsidedecayminutes</c>.</summary>
    public static BasesiegeweaponOutsidedecayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<BasesiegeweaponOutsidedecayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basesiegeweapon.outsidedecayminutes</c> to <paramref name="value"/>.</summary>
    public static BasesiegeweaponOutsidedecayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BasesiegeweaponOutsidedecayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
