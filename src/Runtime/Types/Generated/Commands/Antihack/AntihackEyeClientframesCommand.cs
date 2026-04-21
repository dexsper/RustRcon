using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.eye_clientframes</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.eye_clientframes</c></remarks>
public sealed class AntihackEyeClientframesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.eye_clientframes";

    /// <summary>Reads the current value of <c>antihack.eye_clientframes</c>.</summary>
    public static AntihackEyeClientframesCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackEyeClientframesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.eye_clientframes</c> to <paramref name="value"/>.</summary>
    public static AntihackEyeClientframesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackEyeClientframesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
