using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>env.nightlight_distance</c>.</summary>
/// <remarks>Full RCON name: <c>env.nightlight_distance</c></remarks>
public sealed class EnvNightlightDistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "env.nightlight_distance";

    /// <summary>Reads the current value of <c>env.nightlight_distance</c>.</summary>
    public static EnvNightlightDistanceCommand CreateGet()
    {
        var cmd = CreatePackage<EnvNightlightDistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>env.nightlight_distance</c> to <paramref name="value"/>.</summary>
    public static EnvNightlightDistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<EnvNightlightDistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
