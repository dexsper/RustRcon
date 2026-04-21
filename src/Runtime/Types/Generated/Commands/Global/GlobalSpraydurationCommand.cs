using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Base time (in seconds) that sprays last</summary>
/// <remarks>Full RCON name: <c>global.sprayduration</c></remarks>
public sealed class GlobalSpraydurationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.sprayduration";

    /// <summary>Reads the current value of <c>global.sprayduration</c>.</summary>
    public static GlobalSpraydurationCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalSpraydurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.sprayduration</c> to <paramref name="value"/>.</summary>
    public static GlobalSpraydurationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<GlobalSpraydurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
