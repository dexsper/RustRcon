using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>env.nightlight_brightness</c>.</summary>
/// <remarks>Full RCON name: <c>env.nightlight_brightness</c></remarks>
public sealed class EnvNightlightBrightnessCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "env.nightlight_brightness";

    /// <summary>Reads the current value of <c>env.nightlight_brightness</c>.</summary>
    public static EnvNightlightBrightnessCommand CreateGet()
    {
        var cmd = CreatePackage<EnvNightlightBrightnessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>env.nightlight_brightness</c> to <paramref name="value"/>.</summary>
    public static EnvNightlightBrightnessCommand CreateSet(float value)
    {
        var cmd = CreatePackage<EnvNightlightBrightnessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
