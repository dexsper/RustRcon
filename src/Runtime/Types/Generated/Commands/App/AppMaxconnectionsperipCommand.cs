using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum simultaneous connections from the same IP address; prevents a single host from consuming all connection slots</summary>
/// <remarks>Full RCON name: <c>app.maxconnectionsperip</c></remarks>
public sealed class AppMaxconnectionsperipCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "app.maxconnectionsperip";

    /// <summary>Reads the current value of <c>app.maxconnectionsperip</c>.</summary>
    public static AppMaxconnectionsperipCommand CreateGet()
    {
        var cmd = CreatePackage<AppMaxconnectionsperipCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>app.maxconnectionsperip</c> to <paramref name="value"/>.</summary>
    public static AppMaxconnectionsperipCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AppMaxconnectionsperipCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
