using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Maximum seconds before a deep sea re-opens after closing</summary>
/// <remarks>Full RCON name: <c>deepsea.wipecooldownmax</c></remarks>
public sealed class DeepseaWipecooldownmaxCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.wipecooldownmax";

    /// <summary>Reads the current value of <c>deepsea.wipecooldownmax</c>.</summary>
    public static DeepseaWipecooldownmaxCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaWipecooldownmaxCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.wipecooldownmax</c> to <paramref name="value"/>.</summary>
    public static DeepseaWipecooldownmaxCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaWipecooldownmaxCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
