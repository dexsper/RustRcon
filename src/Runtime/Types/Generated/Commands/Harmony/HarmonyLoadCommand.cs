using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Loads and applies a Harmony patch assembly by file name, enabling server-side code patching without restarting</summary>
/// <remarks>Full RCON name: <c>harmony.load</c></remarks>
public sealed class HarmonyLoadCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "harmony.load";

    /// <summary>Creates a new <see cref="HarmonyLoadCommand"/> command.</summary>
    public static HarmonyLoadCommand Create()
    {
        var cmd = CreatePackage<HarmonyLoadCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
