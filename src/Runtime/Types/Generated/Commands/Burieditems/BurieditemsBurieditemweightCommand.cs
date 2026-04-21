using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Metal detector loot weight is 100.</summary>
/// <remarks>Full RCON name: <c>burieditems.burieditemweight</c></remarks>
public sealed class BurieditemsBurieditemweightCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "burieditems.burieditemweight";

    /// <summary>Reads the current value of <c>burieditems.burieditemweight</c>.</summary>
    public static BurieditemsBurieditemweightCommand CreateGet()
    {
        var cmd = CreatePackage<BurieditemsBurieditemweightCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>burieditems.burieditemweight</c> to <paramref name="value"/>.</summary>
    public static BurieditemsBurieditemweightCommand CreateSet(int value)
    {
        var cmd = CreatePackage<BurieditemsBurieditemweightCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
