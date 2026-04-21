using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>fishing.successesuntiloverfished</c>.</summary>
/// <remarks>Full RCON name: <c>fishing.successesuntiloverfished</c></remarks>
public sealed class FishingSuccessesuntiloverfishedCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "fishing.successesuntiloverfished";

    /// <summary>Reads the current value of <c>fishing.successesuntiloverfished</c>.</summary>
    public static FishingSuccessesuntiloverfishedCommand CreateGet()
    {
        var cmd = CreatePackage<FishingSuccessesuntiloverfishedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>fishing.successesuntiloverfished</c> to <paramref name="value"/>.</summary>
    public static FishingSuccessesuntiloverfishedCommand CreateSet(int value)
    {
        var cmd = CreatePackage<FishingSuccessesuntiloverfishedCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
