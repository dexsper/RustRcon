using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before a HAB loses all its health while outside</summary>
/// <remarks>Full RCON name: <c>hotairballoon.outsidedecayminutes</c></remarks>
public sealed class HotairballoonOutsidedecayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "hotairballoon.outsidedecayminutes";

    /// <summary>Reads the current value of <c>hotairballoon.outsidedecayminutes</c>.</summary>
    public static HotairballoonOutsidedecayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<HotairballoonOutsidedecayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>hotairballoon.outsidedecayminutes</c> to <paramref name="value"/>.</summary>
    public static HotairballoonOutsidedecayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HotairballoonOutsidedecayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
