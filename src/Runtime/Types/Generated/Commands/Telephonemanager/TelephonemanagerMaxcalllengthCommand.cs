using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum duration in seconds a telephone call can remain active before it is automatically terminated</summary>
/// <remarks>Full RCON name: <c>telephonemanager.maxcalllength</c></remarks>
public sealed class TelephonemanagerMaxcalllengthCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "telephonemanager.maxcalllength";

    /// <summary>Reads the current value of <c>telephonemanager.maxcalllength</c>.</summary>
    public static TelephonemanagerMaxcalllengthCommand CreateGet()
    {
        var cmd = CreatePackage<TelephonemanagerMaxcalllengthCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>telephonemanager.maxcalllength</c> to <paramref name="value"/>.</summary>
    public static TelephonemanagerMaxcalllengthCommand CreateSet(int value)
    {
        var cmd = CreatePackage<TelephonemanagerMaxcalllengthCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
