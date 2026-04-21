using RustRcon.Types;
using RustRcon.Types.Commands.Base;
using RustRcon.Generated.Dtos;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>console.search</c>.</summary>
/// <remarks>Full RCON name: <c>console.search</c></remarks>
public sealed class ConsoleSearchCommand : BaseCallCommand<ConsoleEntry[]>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "console.search";

    /// <summary>Creates a new <see cref="ConsoleSearchCommand"/> command.</summary>
    public static ConsoleSearchCommand Create(string search)
    {
        var cmd = CreatePackage<ConsoleSearchCommand>();
        cmd.Content = $"{CommandFullName} {search}";
        return cmd;
    }
}
