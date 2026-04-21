using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cargoship.debug_cargo_status</c>.</summary>
/// <remarks>Full RCON name: <c>cargoship.debug_cargo_status</c></remarks>
public sealed class CargoshipDebugCargoStatusCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cargoship.debug_cargo_status";

    /// <summary>Creates a new <see cref="CargoshipDebugCargoStatusCommand"/> command.</summary>
    public static CargoshipDebugCargoStatusCommand Create()
    {
        var cmd = CreatePackage<CargoshipDebugCargoStatusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
