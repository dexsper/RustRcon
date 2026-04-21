using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.eye_forgiveness</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.eye_forgiveness</c></remarks>
public sealed class AntihackEyeForgivenessCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.eye_forgiveness";

    /// <summary>Reads the current value of <c>antihack.eye_forgiveness</c>.</summary>
    public static AntihackEyeForgivenessCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackEyeForgivenessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.eye_forgiveness</c> to <paramref name="value"/>.</summary>
    public static AntihackEyeForgivenessCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackEyeForgivenessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
