using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>hotairballoon.serviceceiling</c>.</summary>
/// <remarks>Full RCON name: <c>hotairballoon.serviceceiling</c></remarks>
public sealed class HotairballoonServiceceilingCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "hotairballoon.serviceceiling";

    /// <summary>Reads the current value of <c>hotairballoon.serviceceiling</c>.</summary>
    public static HotairballoonServiceceilingCommand CreateGet()
    {
        var cmd = CreatePackage<HotairballoonServiceceilingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>hotairballoon.serviceceiling</c> to <paramref name="value"/>.</summary>
    public static HotairballoonServiceceilingCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HotairballoonServiceceilingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
