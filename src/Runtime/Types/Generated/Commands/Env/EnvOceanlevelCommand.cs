using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>env.oceanlevel</c>.</summary>
/// <remarks>Full RCON name: <c>env.oceanlevel</c></remarks>
public sealed class EnvOceanlevelCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "env.oceanlevel";

    /// <summary>Reads the current value of <c>env.oceanlevel</c>.</summary>
    public static EnvOceanlevelCommand CreateGet()
    {
        var cmd = CreatePackage<EnvOceanlevelCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>env.oceanlevel</c> to <paramref name="value"/>.</summary>
    public static EnvOceanlevelCommand CreateSet(float value)
    {
        var cmd = CreatePackage<EnvOceanlevelCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
