using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Unloads a previously loaded Harmony patch assembly by file name, reverting any code modifications it applied</summary>
/// <remarks>Full RCON name: <c>harmony.unload</c></remarks>
public sealed class HarmonyUnloadCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "harmony.unload";

    /// <summary>Creates a new <see cref="HarmonyUnloadCommand"/> command.</summary>
    public static HarmonyUnloadCommand Create()
    {
        var cmd = CreatePackage<HarmonyUnloadCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
