using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Hides cinematic entities by group (0= none, 1= lights, 2= BGs, 3= props, 4= misc)</summary>
/// <remarks>Full RCON name: <c>cinematicentity.hideobjects</c></remarks>
public sealed class CinematicentityHideobjectsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cinematicentity.hideobjects";

    /// <summary>Creates a new <see cref="CinematicentityHideobjectsCommand"/> command.</summary>
    public static CinematicentityHideobjectsCommand Create()
    {
        var cmd = CreatePackage<CinematicentityHideobjectsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
