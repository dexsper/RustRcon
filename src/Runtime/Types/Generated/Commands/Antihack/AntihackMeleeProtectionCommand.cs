using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.melee_protection</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.melee_protection</c></remarks>
public sealed class AntihackMeleeProtectionCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.melee_protection";

    /// <summary>Reads the current value of <c>antihack.melee_protection</c>.</summary>
    public static AntihackMeleeProtectionCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackMeleeProtectionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.melee_protection</c> to <paramref name="value"/>.</summary>
    public static AntihackMeleeProtectionCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackMeleeProtectionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
