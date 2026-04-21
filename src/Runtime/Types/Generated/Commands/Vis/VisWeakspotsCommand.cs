using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>vis.weakspots</c>.</summary>
/// <remarks>Full RCON name: <c>vis.weakspots</c></remarks>
public sealed class VisWeakspotsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vis.weakspots";

    /// <summary>Reads the current value of <c>vis.weakspots</c>.</summary>
    public static VisWeakspotsCommand CreateGet()
    {
        var cmd = CreatePackage<VisWeakspotsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vis.weakspots</c> to <paramref name="value"/>.</summary>
    public static VisWeakspotsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<VisWeakspotsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
