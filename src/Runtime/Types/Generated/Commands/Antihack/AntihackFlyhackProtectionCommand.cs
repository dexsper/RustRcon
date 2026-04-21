using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.flyhack_protection</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.flyhack_protection</c></remarks>
public sealed class AntihackFlyhackProtectionCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.flyhack_protection";

    /// <summary>Reads the current value of <c>antihack.flyhack_protection</c>.</summary>
    public static AntihackFlyhackProtectionCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackFlyhackProtectionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.flyhack_protection</c> to <paramref name="value"/>.</summary>
    public static AntihackFlyhackProtectionCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackFlyhackProtectionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
