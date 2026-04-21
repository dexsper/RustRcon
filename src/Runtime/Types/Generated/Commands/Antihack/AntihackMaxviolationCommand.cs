using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.maxviolation</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.maxviolation</c></remarks>
public sealed class AntihackMaxviolationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.maxviolation";

    /// <summary>Reads the current value of <c>antihack.maxviolation</c>.</summary>
    public static AntihackMaxviolationCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackMaxviolationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.maxviolation</c> to <paramref name="value"/>.</summary>
    public static AntihackMaxviolationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackMaxviolationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
