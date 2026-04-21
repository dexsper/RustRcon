using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Toggles the deep sea. Needs a server restart to take effect. Any saved deep sea entities will be destroyed at the next startup</summary>
/// <remarks>Full RCON name: <c>deepsea.enabled</c></remarks>
public sealed class DeepseaEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.enabled";

    /// <summary>Reads the current value of <c>deepsea.enabled</c>.</summary>
    public static DeepseaEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.enabled</c> to <paramref name="value"/>.</summary>
    public static DeepseaEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DeepseaEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
