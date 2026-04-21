using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum speed as a fraction of the boat's top speed that AI-controlled boats will use; default 0.9; saved and shown in admin UI</summary>
/// <remarks>Full RCON name: <c>boatai.max_speed_percentage</c></remarks>
public sealed class BoataiMaxSpeedPercentageCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatai.max_speed_percentage";

    /// <summary>Reads the current value of <c>boatai.max_speed_percentage</c>.</summary>
    public static BoataiMaxSpeedPercentageCommand CreateGet()
    {
        var cmd = CreatePackage<BoataiMaxSpeedPercentageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatai.max_speed_percentage</c> to <paramref name="value"/>.</summary>
    public static BoataiMaxSpeedPercentageCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BoataiMaxSpeedPercentageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
