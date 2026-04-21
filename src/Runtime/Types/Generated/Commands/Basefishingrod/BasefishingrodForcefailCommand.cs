using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, all fishing attempts fail immediately; cheat for testing failed-catch animations and UI feedback</summary>
/// <remarks>Full RCON name: <c>basefishingrod.forcefail</c></remarks>
public sealed class BasefishingrodForcefailCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basefishingrod.forcefail";

    /// <summary>Reads the current value of <c>basefishingrod.forcefail</c>.</summary>
    public static BasefishingrodForcefailCommand CreateGet()
    {
        var cmd = CreatePackage<BasefishingrodForcefailCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basefishingrod.forcefail</c> to <paramref name="value"/>.</summary>
    public static BasefishingrodForcefailCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BasefishingrodForcefailCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
