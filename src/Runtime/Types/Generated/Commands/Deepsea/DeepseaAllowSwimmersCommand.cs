using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Allow players to swim to the deep sea</summary>
/// <remarks>Full RCON name: <c>deepsea.allow_swimmers</c></remarks>
public sealed class DeepseaAllowSwimmersCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.allow_swimmers";

    /// <summary>Reads the current value of <c>deepsea.allow_swimmers</c>.</summary>
    public static DeepseaAllowSwimmersCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaAllowSwimmersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.allow_swimmers</c> to <paramref name="value"/>.</summary>
    public static DeepseaAllowSwimmersCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DeepseaAllowSwimmersCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
