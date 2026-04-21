using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.maxdeltatime</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.maxdeltatime</c></remarks>
public sealed class AntihackMaxdeltatimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.maxdeltatime";

    /// <summary>Reads the current value of <c>antihack.maxdeltatime</c>.</summary>
    public static AntihackMaxdeltatimeCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackMaxdeltatimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.maxdeltatime</c> to <paramref name="value"/>.</summary>
    public static AntihackMaxdeltatimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackMaxdeltatimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
