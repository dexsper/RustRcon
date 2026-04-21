using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>santasleigh.desiredaltitude</c>.</summary>
/// <remarks>Full RCON name: <c>santasleigh.desiredaltitude</c></remarks>
public sealed class SantasleighDesiredaltitudeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "santasleigh.desiredaltitude";

    /// <summary>Reads the current value of <c>santasleigh.desiredaltitude</c>.</summary>
    public static SantasleighDesiredaltitudeCommand CreateGet()
    {
        var cmd = CreatePackage<SantasleighDesiredaltitudeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>santasleigh.desiredaltitude</c> to <paramref name="value"/>.</summary>
    public static SantasleighDesiredaltitudeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SantasleighDesiredaltitudeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
