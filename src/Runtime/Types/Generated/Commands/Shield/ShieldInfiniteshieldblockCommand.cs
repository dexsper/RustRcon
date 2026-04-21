using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>shield.infiniteshieldblock</c>.</summary>
/// <remarks>Full RCON name: <c>shield.infiniteshieldblock</c></remarks>
public sealed class ShieldInfiniteshieldblockCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "shield.infiniteshieldblock";

    /// <summary>Reads the current value of <c>shield.infiniteshieldblock</c>.</summary>
    public static ShieldInfiniteshieldblockCommand CreateGet()
    {
        var cmd = CreatePackage<ShieldInfiniteshieldblockCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>shield.infiniteshieldblock</c> to <paramref name="value"/>.</summary>
    public static ShieldInfiniteshieldblockCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ShieldInfiniteshieldblockCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
