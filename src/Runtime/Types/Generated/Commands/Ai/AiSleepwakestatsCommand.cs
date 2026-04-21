using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints statistics about AI sleeping zones: how many zones are sleepable, how many are sleeping, and the total count of sleeping entities</summary>
/// <remarks>Full RCON name: <c>ai.sleepwakestats</c></remarks>
public sealed class AiSleepwakestatsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.sleepwakestats";

    /// <summary>Creates a new <see cref="AiSleepwakestatsCommand"/> command.</summary>
    public static AiSleepwakestatsCommand Create()
    {
        var cmd = CreatePackage<AiSleepwakestatsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
