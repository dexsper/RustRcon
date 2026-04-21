using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Simulates the provided number of hours on all farm animals within 10m</summary>
/// <remarks>Full RCON name: <c>farmableanimal.simhours</c></remarks>
public sealed class FarmableanimalSimhoursCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "farmableanimal.simhours";

    /// <summary>Creates a new <see cref="FarmableanimalSimhoursCommand"/> command.</summary>
    public static FarmableanimalSimhoursCommand Create()
    {
        var cmd = CreatePackage<FarmableanimalSimhoursCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
