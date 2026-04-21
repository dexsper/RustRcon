using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Bypasses all placement checks</summary>
/// <remarks>Full RCON name: <c>creative.freeplacement</c></remarks>
public sealed class CreativeFreeplacementCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "creative.freeplacement";

    /// <summary>Reads the current value of <c>creative.freeplacement</c>.</summary>
    public static CreativeFreeplacementCommand CreateGet()
    {
        var cmd = CreatePackage<CreativeFreeplacementCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>creative.freeplacement</c> to <paramref name="value"/>.</summary>
    public static CreativeFreeplacementCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CreativeFreeplacementCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
