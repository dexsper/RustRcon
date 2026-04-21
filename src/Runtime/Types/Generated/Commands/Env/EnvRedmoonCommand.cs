using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>env.redmoon</c>.</summary>
/// <remarks>Full RCON name: <c>env.redmoon</c></remarks>
public sealed class EnvRedmoonCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "env.redmoon";

    /// <summary>Reads the current value of <c>env.redmoon</c>.</summary>
    public static EnvRedmoonCommand CreateGet()
    {
        var cmd = CreatePackage<EnvRedmoonCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>env.redmoon</c> to <paramref name="value"/>.</summary>
    public static EnvRedmoonCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<EnvRedmoonCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
