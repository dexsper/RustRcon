using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Duration in seconds of the final wipe phase, bad weather kicking in etc</summary>
/// <remarks>Full RCON name: <c>deepsea.wipeendphaseduration</c></remarks>
public sealed class DeepseaWipeendphasedurationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.wipeendphaseduration";

    /// <summary>Reads the current value of <c>deepsea.wipeendphaseduration</c>.</summary>
    public static DeepseaWipeendphasedurationCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaWipeendphasedurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.wipeendphaseduration</c> to <paramref name="value"/>.</summary>
    public static DeepseaWipeendphasedurationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaWipeendphasedurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
