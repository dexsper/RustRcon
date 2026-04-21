using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before a submarine loses all its health while in deep water</summary>
/// <remarks>Full RCON name: <c>basesubmarine.deepwaterdecayminutes</c></remarks>
public sealed class BasesubmarineDeepwaterdecayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basesubmarine.deepwaterdecayminutes";

    /// <summary>Reads the current value of <c>basesubmarine.deepwaterdecayminutes</c>.</summary>
    public static BasesubmarineDeepwaterdecayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<BasesubmarineDeepwaterdecayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basesubmarine.deepwaterdecayminutes</c> to <paramref name="value"/>.</summary>
    public static BasesubmarineDeepwaterdecayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BasesubmarineDeepwaterdecayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
