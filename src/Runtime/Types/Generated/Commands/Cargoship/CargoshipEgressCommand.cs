using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cargoship.egress</c>.</summary>
/// <remarks>Full RCON name: <c>cargoship.egress</c></remarks>
public sealed class CargoshipEgressCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cargoship.egress";

    /// <summary>Creates a new <see cref="CargoshipEgressCommand"/> command.</summary>
    public static CargoshipEgressCommand Create()
    {
        var cmd = CreatePackage<CargoshipEgressCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
