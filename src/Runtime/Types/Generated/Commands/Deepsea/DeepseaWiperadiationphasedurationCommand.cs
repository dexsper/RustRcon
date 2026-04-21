using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Seconds before radiation starts to ramp in before the deep sea wipe</summary>
/// <remarks>Full RCON name: <c>deepsea.wiperadiationphaseduration</c></remarks>
public sealed class DeepseaWiperadiationphasedurationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.wiperadiationphaseduration";

    /// <summary>Reads the current value of <c>deepsea.wiperadiationphaseduration</c>.</summary>
    public static DeepseaWiperadiationphasedurationCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaWiperadiationphasedurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.wiperadiationphaseduration</c> to <paramref name="value"/>.</summary>
    public static DeepseaWiperadiationphasedurationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaWiperadiationphasedurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
