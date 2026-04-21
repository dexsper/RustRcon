using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints all scenes registered in the build settings with their build index and asset path</summary>
/// <remarks>Full RCON name: <c>global.printallscenesinbuild</c></remarks>
public sealed class GlobalPrintallscenesinbuildCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.printallscenesinbuild";

    /// <summary>Creates a new <see cref="GlobalPrintallscenesinbuildCommand"/> command.</summary>
    public static GlobalPrintallscenesinbuildCommand Create()
    {
        var cmd = CreatePackage<GlobalPrintallscenesinbuildCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
