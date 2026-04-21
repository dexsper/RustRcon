using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum allowed size in bytes of a single network message; oversized messages are dropped to prevent memory exhaustion attacks</summary>
/// <remarks>Full RCON name: <c>app.maxmessagesize</c></remarks>
public sealed class AppMaxmessagesizeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "app.maxmessagesize";

    /// <summary>Reads the current value of <c>app.maxmessagesize</c>.</summary>
    public static AppMaxmessagesizeCommand CreateGet()
    {
        var cmd = CreatePackage<AppMaxmessagesizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>app.maxmessagesize</c> to <paramref name="value"/>.</summary>
    public static AppMaxmessagesizeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AppMaxmessagesizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
