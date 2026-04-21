using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Minimum distance in metres RHIB groups must be from the deep sea boundary edge when spawning</summary>
/// <remarks>Full RCON name: <c>deepsea.rhib_edgemargin</c></remarks>
public sealed class DeepseaRhibEdgemarginCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.rhib_edgemargin";

    /// <summary>Reads the current value of <c>deepsea.rhib_edgemargin</c>.</summary>
    public static DeepseaRhibEdgemarginCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaRhibEdgemarginCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.rhib_edgemargin</c> to <paramref name="value"/>.</summary>
    public static DeepseaRhibEdgemarginCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaRhibEdgemarginCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
