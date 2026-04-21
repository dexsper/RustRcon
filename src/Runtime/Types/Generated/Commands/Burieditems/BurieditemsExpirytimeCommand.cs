using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Time in seconds before an item expires.</summary>
/// <remarks>Full RCON name: <c>burieditems.expirytime</c></remarks>
public sealed class BurieditemsExpirytimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "burieditems.expirytime";

    /// <summary>Reads the current value of <c>burieditems.expirytime</c>.</summary>
    public static BurieditemsExpirytimeCommand CreateGet()
    {
        var cmd = CreatePackage<BurieditemsExpirytimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>burieditems.expirytime</c> to <paramref name="value"/>.</summary>
    public static BurieditemsExpirytimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BurieditemsExpirytimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
