using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.speedhack_slopespeed</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.speedhack_slopespeed</c></remarks>
public sealed class AntihackSpeedhackSlopespeedCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.speedhack_slopespeed";

    /// <summary>Reads the current value of <c>antihack.speedhack_slopespeed</c>.</summary>
    public static AntihackSpeedhackSlopespeedCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackSpeedhackSlopespeedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.speedhack_slopespeed</c> to <paramref name="value"/>.</summary>
    public static AntihackSpeedhackSlopespeedCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackSpeedhackSlopespeedCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
