using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of simultaneous player connections allowed; connections above this limit are rejected with a server full message</summary>
/// <remarks>Full RCON name: <c>app.maxconnections</c></remarks>
public sealed class AppMaxconnectionsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "app.maxconnections";

    /// <summary>Reads the current value of <c>app.maxconnections</c>.</summary>
    public static AppMaxconnectionsCommand CreateGet()
    {
        var cmd = CreatePackage<AppMaxconnectionsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>app.maxconnections</c> to <paramref name="value"/>.</summary>
    public static AppMaxconnectionsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AppMaxconnectionsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
