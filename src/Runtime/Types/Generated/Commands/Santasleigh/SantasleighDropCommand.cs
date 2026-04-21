using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>santasleigh.drop</c>.</summary>
/// <remarks>Full RCON name: <c>santasleigh.drop</c></remarks>
public sealed class SantasleighDropCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "santasleigh.drop";

    /// <summary>Creates a new <see cref="SantasleighDropCommand"/> command.</summary>
    public static SantasleighDropCommand Create()
    {
        var cmd = CreatePackage<SantasleighDropCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
