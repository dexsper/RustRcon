using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Delay before SAM sites that haven't shot a target will auto-reload</summary>
/// <remarks>Full RCON name: <c>samsite.autoreloaddelay</c></remarks>
public sealed class SamsiteAutoreloaddelayCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "samsite.autoreloaddelay";

    /// <summary>Reads the current value of <c>samsite.autoreloaddelay</c>.</summary>
    public static SamsiteAutoreloaddelayCommand CreateGet()
    {
        var cmd = CreatePackage<SamsiteAutoreloaddelayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>samsite.autoreloaddelay</c> to <paramref name="value"/>.</summary>
    public static SamsiteAutoreloaddelayCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SamsiteAutoreloaddelayCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
