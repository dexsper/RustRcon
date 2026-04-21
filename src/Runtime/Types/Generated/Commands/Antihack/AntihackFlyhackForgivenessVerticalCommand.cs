using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.flyhack_forgiveness_vertical</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.flyhack_forgiveness_vertical</c></remarks>
public sealed class AntihackFlyhackForgivenessVerticalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.flyhack_forgiveness_vertical";

    /// <summary>Reads the current value of <c>antihack.flyhack_forgiveness_vertical</c>.</summary>
    public static AntihackFlyhackForgivenessVerticalCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackFlyhackForgivenessVerticalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.flyhack_forgiveness_vertical</c> to <paramref name="value"/>.</summary>
    public static AntihackFlyhackForgivenessVerticalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackFlyhackForgivenessVerticalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
