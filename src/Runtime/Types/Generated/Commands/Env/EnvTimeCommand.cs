using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Gets or sets the current in-game time of day as a decimal hour (0.0-24.0); writing a value immediately jumps the time to that point</summary>
/// <remarks>Full RCON name: <c>env.time</c></remarks>
public sealed class EnvTimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "env.time";

    /// <summary>Reads the current value of <c>env.time</c>.</summary>
    public static EnvTimeCommand CreateGet()
    {
        var cmd = CreatePackage<EnvTimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>env.time</c> to <paramref name="value"/>.</summary>
    public static EnvTimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<EnvTimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
