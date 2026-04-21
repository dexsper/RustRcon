using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>playerboat.maxblockcount</c>.</summary>
/// <remarks>Full RCON name: <c>playerboat.maxblockcount</c></remarks>
public sealed class PlayerboatMaxblockcountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.maxblockcount";

    /// <summary>Reads the current value of <c>playerboat.maxblockcount</c>.</summary>
    public static PlayerboatMaxblockcountCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatMaxblockcountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.maxblockcount</c> to <paramref name="value"/>.</summary>
    public static PlayerboatMaxblockcountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<PlayerboatMaxblockcountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
