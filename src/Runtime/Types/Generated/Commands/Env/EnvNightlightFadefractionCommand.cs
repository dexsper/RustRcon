using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>env.nightlight_fadefraction</c>.</summary>
/// <remarks>Full RCON name: <c>env.nightlight_fadefraction</c></remarks>
public sealed class EnvNightlightFadefractionCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "env.nightlight_fadefraction";

    /// <summary>Reads the current value of <c>env.nightlight_fadefraction</c>.</summary>
    public static EnvNightlightFadefractionCommand CreateGet()
    {
        var cmd = CreatePackage<EnvNightlightFadefractionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>env.nightlight_fadefraction</c> to <paramref name="value"/>.</summary>
    public static EnvNightlightFadefractionCommand CreateSet(float value)
    {
        var cmd = CreatePackage<EnvNightlightFadefractionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
