using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>parachute.landinganimations</c>.</summary>
/// <remarks>Full RCON name: <c>parachute.landinganimations</c></remarks>
public sealed class ParachuteLandinganimationsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "parachute.landinganimations";

    /// <summary>Reads the current value of <c>parachute.landinganimations</c>.</summary>
    public static ParachuteLandinganimationsCommand CreateGet()
    {
        var cmd = CreatePackage<ParachuteLandinganimationsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>parachute.landinganimations</c> to <paramref name="value"/>.</summary>
    public static ParachuteLandinganimationsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ParachuteLandinganimationsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
