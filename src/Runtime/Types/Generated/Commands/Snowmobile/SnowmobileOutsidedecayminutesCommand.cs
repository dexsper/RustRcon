using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before a snowmobile loses all its health while outside</summary>
/// <remarks>Full RCON name: <c>snowmobile.outsidedecayminutes</c></remarks>
public sealed class SnowmobileOutsidedecayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "snowmobile.outsidedecayminutes";

    /// <summary>Reads the current value of <c>snowmobile.outsidedecayminutes</c>.</summary>
    public static SnowmobileOutsidedecayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<SnowmobileOutsidedecayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>snowmobile.outsidedecayminutes</c> to <paramref name="value"/>.</summary>
    public static SnowmobileOutsidedecayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SnowmobileOutsidedecayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
