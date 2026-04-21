using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.eye_protection</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.eye_protection</c></remarks>
public sealed class AntihackEyeProtectionCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.eye_protection";

    /// <summary>Reads the current value of <c>antihack.eye_protection</c>.</summary>
    public static AntihackEyeProtectionCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackEyeProtectionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.eye_protection</c> to <paramref name="value"/>.</summary>
    public static AntihackEyeProtectionCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackEyeProtectionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
