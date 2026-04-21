using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many minutes before a ModularCar loses all its health while outside</summary>
/// <remarks>Full RCON name: <c>modularcar.outsidedecayminutes</c></remarks>
public sealed class ModularcarOutsidedecayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "modularcar.outsidedecayminutes";

    /// <summary>Reads the current value of <c>modularcar.outsidedecayminutes</c>.</summary>
    public static ModularcarOutsidedecayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<ModularcarOutsidedecayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>modularcar.outsidedecayminutes</c> to <paramref name="value"/>.</summary>
    public static ModularcarOutsidedecayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ModularcarOutsidedecayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
