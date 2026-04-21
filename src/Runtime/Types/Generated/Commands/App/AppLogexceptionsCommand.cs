using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, server-side C# exceptions are written to the server log file; disabling reduces log noise on servers with known non-critical exceptions</summary>
/// <remarks>Full RCON name: <c>app.logexceptions</c></remarks>
public sealed class AppLogexceptionsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "app.logexceptions";

    /// <summary>Reads the current value of <c>app.logexceptions</c>.</summary>
    public static AppLogexceptionsCommand CreateGet()
    {
        var cmd = CreatePackage<AppLogexceptionsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>app.logexceptions</c> to <paramref name="value"/>.</summary>
    public static AppLogexceptionsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AppLogexceptionsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
