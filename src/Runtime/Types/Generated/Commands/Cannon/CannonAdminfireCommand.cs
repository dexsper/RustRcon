using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cannon.adminfire</c>.</summary>
/// <remarks>Full RCON name: <c>cannon.adminfire</c></remarks>
public sealed class CannonAdminfireCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cannon.adminfire";

    /// <summary>Creates a new <see cref="CannonAdminfireCommand"/> command.</summary>
    public static CannonAdminfireCommand Create()
    {
        var cmd = CreatePackage<CannonAdminfireCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
