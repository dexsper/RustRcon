using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.biome_fog_distance_curve</c>.</summary>
/// <remarks>Full RCON name: <c>weather.biome_fog_distance_curve</c></remarks>
public sealed class WeatherBiomeFogDistanceCurveCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.biome_fog_distance_curve";

    /// <summary>Reads the current value of <c>weather.biome_fog_distance_curve</c>.</summary>
    public static WeatherBiomeFogDistanceCurveCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherBiomeFogDistanceCurveCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.biome_fog_distance_curve</c> to <paramref name="value"/>.</summary>
    public static WeatherBiomeFogDistanceCurveCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherBiomeFogDistanceCurveCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
