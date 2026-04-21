using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cargoship.debug_info</c>.</summary>
/// <remarks>Full RCON name: <c>cargoship.debug_info</c></remarks>
public sealed class CargoshipDebugInfoCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cargoship.debug_info";

    /// <summary>Creates a new <see cref="CargoshipDebugInfoCommand"/> command.</summary>
    public static CargoshipDebugInfoCommand Create()
    {
        var cmd = CreatePackage<CargoshipDebugInfoCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
