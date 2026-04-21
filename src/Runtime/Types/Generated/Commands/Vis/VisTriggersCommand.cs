using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>vis.triggers</c>.</summary>
/// <remarks>Full RCON name: <c>vis.triggers</c></remarks>
public sealed class VisTriggersCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vis.triggers";

    /// <summary>Reads the current value of <c>vis.triggers</c>.</summary>
    public static VisTriggersCommand CreateGet()
    {
        var cmd = CreatePackage<VisTriggersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vis.triggers</c> to <paramref name="value"/>.</summary>
    public static VisTriggersCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<VisTriggersCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
