using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.flyhack_forgiveness_vertical_inertia</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.flyhack_forgiveness_vertical_inertia</c></remarks>
public sealed class AntihackFlyhackForgivenessVerticalInertiaCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.flyhack_forgiveness_vertical_inertia";

    /// <summary>Reads the current value of <c>antihack.flyhack_forgiveness_vertical_inertia</c>.</summary>
    public static AntihackFlyhackForgivenessVerticalInertiaCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackFlyhackForgivenessVerticalInertiaCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.flyhack_forgiveness_vertical_inertia</c> to <paramref name="value"/>.</summary>
    public static AntihackFlyhackForgivenessVerticalInertiaCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackFlyhackForgivenessVerticalInertiaCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
