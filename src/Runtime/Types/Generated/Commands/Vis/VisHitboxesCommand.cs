using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>vis.hitboxes</c>.</summary>
/// <remarks>Full RCON name: <c>vis.hitboxes</c></remarks>
public sealed class VisHitboxesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vis.hitboxes";

    /// <summary>Reads the current value of <c>vis.hitboxes</c>.</summary>
    public static VisHitboxesCommand CreateGet()
    {
        var cmd = CreatePackage<VisHitboxesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vis.hitboxes</c> to <paramref name="value"/>.</summary>
    public static VisHitboxesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<VisHitboxesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
