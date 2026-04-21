using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.flyhack_forgiveness_horizontal</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.flyhack_forgiveness_horizontal</c></remarks>
public sealed class AntihackFlyhackForgivenessHorizontalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.flyhack_forgiveness_horizontal";

    /// <summary>Reads the current value of <c>antihack.flyhack_forgiveness_horizontal</c>.</summary>
    public static AntihackFlyhackForgivenessHorizontalCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackFlyhackForgivenessHorizontalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.flyhack_forgiveness_horizontal</c> to <paramref name="value"/>.</summary>
    public static AntihackFlyhackForgivenessHorizontalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackFlyhackForgivenessHorizontalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
