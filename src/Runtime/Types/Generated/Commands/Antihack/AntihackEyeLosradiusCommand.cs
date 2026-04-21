using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.eye_losradius</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.eye_losradius</c></remarks>
public sealed class AntihackEyeLosradiusCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.eye_losradius";

    /// <summary>Reads the current value of <c>antihack.eye_losradius</c>.</summary>
    public static AntihackEyeLosradiusCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackEyeLosradiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.eye_losradius</c> to <paramref name="value"/>.</summary>
    public static AntihackEyeLosradiusCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackEyeLosradiusCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
