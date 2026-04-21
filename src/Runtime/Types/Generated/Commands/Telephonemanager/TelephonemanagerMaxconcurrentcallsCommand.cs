using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of simultaneous active telephone calls allowed on the server at any time</summary>
/// <remarks>Full RCON name: <c>telephonemanager.maxconcurrentcalls</c></remarks>
public sealed class TelephonemanagerMaxconcurrentcallsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "telephonemanager.maxconcurrentcalls";

    /// <summary>Reads the current value of <c>telephonemanager.maxconcurrentcalls</c>.</summary>
    public static TelephonemanagerMaxconcurrentcallsCommand CreateGet()
    {
        var cmd = CreatePackage<TelephonemanagerMaxconcurrentcallsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>telephonemanager.maxconcurrentcalls</c> to <paramref name="value"/>.</summary>
    public static TelephonemanagerMaxconcurrentcallsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<TelephonemanagerMaxconcurrentcallsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
