using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before a bike loses all its health while outside</summary>
/// <remarks>Full RCON name: <c>bike.outsidedecayminutes</c></remarks>
public sealed class BikeOutsidedecayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bike.outsidedecayminutes";

    /// <summary>Reads the current value of <c>bike.outsidedecayminutes</c>.</summary>
    public static BikeOutsidedecayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<BikeOutsidedecayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bike.outsidedecayminutes</c> to <paramref name="value"/>.</summary>
    public static BikeOutsidedecayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BikeOutsidedecayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
