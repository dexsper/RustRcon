using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.eye_serverframes</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.eye_serverframes</c></remarks>
public sealed class AntihackEyeServerframesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.eye_serverframes";

    /// <summary>Reads the current value of <c>antihack.eye_serverframes</c>.</summary>
    public static AntihackEyeServerframesCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackEyeServerframesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.eye_serverframes</c> to <paramref name="value"/>.</summary>
    public static AntihackEyeServerframesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackEyeServerframesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
