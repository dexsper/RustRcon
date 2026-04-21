using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Target number of gift entities to maintain per connected player during the xmas event; controls overall gift density on the server</summary>
/// <remarks>Full RCON name: <c>xmas.giftsperplayer</c></remarks>
public sealed class XmasGiftsperplayerCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "xmas.giftsperplayer";

    /// <summary>Reads the current value of <c>xmas.giftsperplayer</c>.</summary>
    public static XmasGiftsperplayerCommand CreateGet()
    {
        var cmd = CreatePackage<XmasGiftsperplayerCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>xmas.giftsperplayer</c> to <paramref name="value"/>.</summary>
    public static XmasGiftsperplayerCommand CreateSet(int value)
    {
        var cmd = CreatePackage<XmasGiftsperplayerCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
