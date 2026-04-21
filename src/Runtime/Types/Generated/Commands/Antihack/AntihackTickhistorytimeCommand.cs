using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.tickhistorytime</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.tickhistorytime</c></remarks>
public sealed class AntihackTickhistorytimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.tickhistorytime";

    /// <summary>Reads the current value of <c>antihack.tickhistorytime</c>.</summary>
    public static AntihackTickhistorytimeCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackTickhistorytimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.tickhistorytime</c> to <paramref name="value"/>.</summary>
    public static AntihackTickhistorytimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackTickhistorytimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
