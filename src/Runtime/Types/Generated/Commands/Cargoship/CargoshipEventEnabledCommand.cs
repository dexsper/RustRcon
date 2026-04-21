using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cargoship.event_enabled</c>.</summary>
/// <remarks>Full RCON name: <c>cargoship.event_enabled</c></remarks>
public sealed class CargoshipEventEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cargoship.event_enabled";

    /// <summary>Reads the current value of <c>cargoship.event_enabled</c>.</summary>
    public static CargoshipEventEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<CargoshipEventEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>cargoship.event_enabled</c> to <paramref name="value"/>.</summary>
    public static CargoshipEventEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CargoshipEventEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
