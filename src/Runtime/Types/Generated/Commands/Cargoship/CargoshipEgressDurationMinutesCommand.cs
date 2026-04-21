using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cargoship.egress_duration_minutes</c>.</summary>
/// <remarks>Full RCON name: <c>cargoship.egress_duration_minutes</c></remarks>
public sealed class CargoshipEgressDurationMinutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cargoship.egress_duration_minutes";

    /// <summary>Reads the current value of <c>cargoship.egress_duration_minutes</c>.</summary>
    public static CargoshipEgressDurationMinutesCommand CreateGet()
    {
        var cmd = CreatePackage<CargoshipEgressDurationMinutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>cargoship.egress_duration_minutes</c> to <paramref name="value"/>.</summary>
    public static CargoshipEgressDurationMinutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<CargoshipEgressDurationMinutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
