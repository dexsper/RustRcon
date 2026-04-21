using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the unique device identifier for the current machine as reported by Unity SystemInfo.deviceUniqueIdentifier</summary>
/// <remarks>Full RCON name: <c>global.sysuid</c></remarks>
public sealed class GlobalSysuidCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.sysuid";

    /// <summary>Creates a new <see cref="GlobalSysuidCommand"/> command.</summary>
    public static GlobalSysuidCommand Create()
    {
        var cmd = CreatePackage<GlobalSysuidCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
