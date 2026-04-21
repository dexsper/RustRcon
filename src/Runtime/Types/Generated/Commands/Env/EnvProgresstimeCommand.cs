using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, the server advances the in-game time of day automatically; disabling freezes time at its current value</summary>
/// <remarks>Full RCON name: <c>env.progresstime</c></remarks>
public sealed class EnvProgresstimeCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "env.progresstime";

    /// <summary>Reads the current value of <c>env.progresstime</c>.</summary>
    public static EnvProgresstimeCommand CreateGet()
    {
        var cmd = CreatePackage<EnvProgresstimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>env.progresstime</c> to <paramref name="value"/>.</summary>
    public static EnvProgresstimeCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<EnvProgresstimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
