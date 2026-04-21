using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Advances the in-game time of day by the specified number of hours; useful for quickly cycling to day or night for testing</summary>
/// <remarks>Full RCON name: <c>env.addtime</c></remarks>
public sealed class EnvAddtimeCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "env.addtime";

    /// <summary>Creates a new <see cref="EnvAddtimeCommand"/> command.</summary>
    public static EnvAddtimeCommand Create()
    {
        var cmd = CreatePackage<EnvAddtimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
