using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Duration in seconds of the deep sea wipe</summary>
/// <remarks>Full RCON name: <c>deepsea.wipeduration</c></remarks>
public sealed class DeepseaWipedurationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.wipeduration";

    /// <summary>Reads the current value of <c>deepsea.wipeduration</c>.</summary>
    public static DeepseaWipedurationCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaWipedurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.wipeduration</c> to <paramref name="value"/>.</summary>
    public static DeepseaWipedurationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaWipedurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
