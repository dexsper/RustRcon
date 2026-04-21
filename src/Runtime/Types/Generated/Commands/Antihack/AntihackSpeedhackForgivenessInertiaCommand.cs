using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.speedhack_forgiveness_inertia</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.speedhack_forgiveness_inertia</c></remarks>
public sealed class AntihackSpeedhackForgivenessInertiaCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.speedhack_forgiveness_inertia";

    /// <summary>Reads the current value of <c>antihack.speedhack_forgiveness_inertia</c>.</summary>
    public static AntihackSpeedhackForgivenessInertiaCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackSpeedhackForgivenessInertiaCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.speedhack_forgiveness_inertia</c> to <paramref name="value"/>.</summary>
    public static AntihackSpeedhackForgivenessInertiaCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackSpeedhackForgivenessInertiaCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
