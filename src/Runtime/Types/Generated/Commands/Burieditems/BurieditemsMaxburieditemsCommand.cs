using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>burieditems.maxburieditems</c>.</summary>
/// <remarks>Full RCON name: <c>burieditems.maxburieditems</c></remarks>
public sealed class BurieditemsMaxburieditemsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "burieditems.maxburieditems";

    /// <summary>Reads the current value of <c>burieditems.maxburieditems</c>.</summary>
    public static BurieditemsMaxburieditemsCommand CreateGet()
    {
        var cmd = CreatePackage<BurieditemsMaxburieditemsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>burieditems.maxburieditems</c> to <paramref name="value"/>.</summary>
    public static BurieditemsMaxburieditemsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<BurieditemsMaxburieditemsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
