using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Sends a message in chat</summary>
/// <remarks>Full RCON name: <c>global.say</c></remarks>
public sealed class GlobalSayCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.say";

    /// <summary>Creates a new <see cref="GlobalSayCommand"/> command.</summary>
    public static GlobalSayCommand Create()
    {
        var cmd = CreatePackage<GlobalSayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
