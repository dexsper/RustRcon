using RustRcon.Types;
using RustRcon.Types.Commands.Base;
using RustRcon.Generated.Dtos;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>console.tail</c>.</summary>
/// <remarks>Full RCON name: <c>console.tail</c></remarks>
public sealed class ConsoleTailCommand : BaseCallCommand<ConsoleEntry[]>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "console.tail";

    /// <summary>Creates a new <see cref="ConsoleTailCommand"/> command.</summary>
    public static ConsoleTailCommand Create(int value)
    {
        var cmd = CreatePackage<ConsoleTailCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
