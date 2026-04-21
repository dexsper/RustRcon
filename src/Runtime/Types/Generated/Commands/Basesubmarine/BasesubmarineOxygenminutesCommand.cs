using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long a submarine can stay underwater until players start taking damage from low oxygen</summary>
/// <remarks>Full RCON name: <c>basesubmarine.oxygenminutes</c></remarks>
public sealed class BasesubmarineOxygenminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basesubmarine.oxygenminutes";

    /// <summary>Reads the current value of <c>basesubmarine.oxygenminutes</c>.</summary>
    public static BasesubmarineOxygenminutesCommand CreateGet()
    {
        var cmd = CreatePackage<BasesubmarineOxygenminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basesubmarine.oxygenminutes</c> to <paramref name="value"/>.</summary>
    public static BasesubmarineOxygenminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BasesubmarineOxygenminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
