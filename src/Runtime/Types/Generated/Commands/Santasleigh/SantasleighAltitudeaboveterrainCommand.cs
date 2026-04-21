using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>santasleigh.altitudeaboveterrain</c>.</summary>
/// <remarks>Full RCON name: <c>santasleigh.altitudeaboveterrain</c></remarks>
public sealed class SantasleighAltitudeaboveterrainCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "santasleigh.altitudeaboveterrain";

    /// <summary>Reads the current value of <c>santasleigh.altitudeaboveterrain</c>.</summary>
    public static SantasleighAltitudeaboveterrainCommand CreateGet()
    {
        var cmd = CreatePackage<SantasleighAltitudeaboveterrainCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>santasleigh.altitudeaboveterrain</c> to <paramref name="value"/>.</summary>
    public static SantasleighAltitudeaboveterrainCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SantasleighAltitudeaboveterrainCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
