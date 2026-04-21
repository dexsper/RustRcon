using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before a submarine loses all its health while outside. If it's in deep water, deepwaterdecayminutes is used</summary>
/// <remarks>Full RCON name: <c>basesubmarine.outsidedecayminutes</c></remarks>
public sealed class BasesubmarineOutsidedecayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basesubmarine.outsidedecayminutes";

    /// <summary>Reads the current value of <c>basesubmarine.outsidedecayminutes</c>.</summary>
    public static BasesubmarineOutsidedecayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<BasesubmarineOutsidedecayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basesubmarine.outsidedecayminutes</c> to <paramref name="value"/>.</summary>
    public static BasesubmarineOutsidedecayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BasesubmarineOutsidedecayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
