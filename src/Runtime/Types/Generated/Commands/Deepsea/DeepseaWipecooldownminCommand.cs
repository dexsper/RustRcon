using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Minimum seconds before a deep sea re-opens after closing</summary>
/// <remarks>Full RCON name: <c>deepsea.wipecooldownmin</c></remarks>
public sealed class DeepseaWipecooldownminCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.wipecooldownmin";

    /// <summary>Reads the current value of <c>deepsea.wipecooldownmin</c>.</summary>
    public static DeepseaWipecooldownminCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaWipecooldownminCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.wipecooldownmin</c> to <paramref name="value"/>.</summary>
    public static DeepseaWipecooldownminCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaWipecooldownminCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
