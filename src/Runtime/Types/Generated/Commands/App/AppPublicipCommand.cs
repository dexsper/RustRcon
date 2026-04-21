using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Public IP address advertised to the Steam server browser; leave empty to auto-detect; set explicitly if behind NAT</summary>
/// <remarks>Full RCON name: <c>app.publicip</c></remarks>
public sealed class AppPublicipCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "app.publicip";

    /// <summary>Reads the current value of <c>app.publicip</c>.</summary>
    public static AppPublicipCommand CreateGet()
    {
        var cmd = CreatePackage<AppPublicipCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>app.publicip</c> to <paramref name="value"/>.</summary>
    public static AppPublicipCommand CreateSet(string value)
    {
        var cmd = CreatePackage<AppPublicipCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
