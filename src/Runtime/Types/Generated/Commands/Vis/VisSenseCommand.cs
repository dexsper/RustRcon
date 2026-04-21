using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>vis.sense</c>.</summary>
/// <remarks>Full RCON name: <c>vis.sense</c></remarks>
public sealed class VisSenseCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vis.sense";

    /// <summary>Reads the current value of <c>vis.sense</c>.</summary>
    public static VisSenseCommand CreateGet()
    {
        var cmd = CreatePackage<VisSenseCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vis.sense</c> to <paramref name="value"/>.</summary>
    public static VisSenseCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<VisSenseCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
