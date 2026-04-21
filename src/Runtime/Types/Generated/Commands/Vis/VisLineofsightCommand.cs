using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>vis.lineofsight</c>.</summary>
/// <remarks>Full RCON name: <c>vis.lineofsight</c></remarks>
public sealed class VisLineofsightCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vis.lineofsight";

    /// <summary>Reads the current value of <c>vis.lineofsight</c>.</summary>
    public static VisLineofsightCommand CreateGet()
    {
        var cmd = CreatePackage<VisLineofsightCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vis.lineofsight</c> to <paramref name="value"/>.</summary>
    public static VisLineofsightCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<VisLineofsightCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
