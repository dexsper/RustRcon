using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.ocean_scale</c>.</summary>
/// <remarks>Full RCON name: <c>weather.ocean_scale</c></remarks>
public sealed class WeatherOceanScaleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.ocean_scale";

    /// <summary>Reads the current value of <c>weather.ocean_scale</c>.</summary>
    public static WeatherOceanScaleCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherOceanScaleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.ocean_scale</c> to <paramref name="value"/>.</summary>
    public static WeatherOceanScaleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherOceanScaleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
