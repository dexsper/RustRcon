using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) How many minutes the patrol helicopter stays airborne before self-destructing; default is 30 minutes</summary>
/// <remarks>Full RCON name: <c>heli.lifetimeminutes</c></remarks>
public sealed class HeliLifetimeminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "heli.lifetimeminutes";

    /// <summary>Reads the current value of <c>heli.lifetimeminutes</c>.</summary>
    public static HeliLifetimeminutesCommand CreateGet()
    {
        var cmd = CreatePackage<HeliLifetimeminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>heli.lifetimeminutes</c> to <paramref name="value"/>.</summary>
    public static HeliLifetimeminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HeliLifetimeminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
