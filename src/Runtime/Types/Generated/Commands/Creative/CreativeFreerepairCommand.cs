using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Bypass the 30s repair cooldown when repairing objects</summary>
/// <remarks>Full RCON name: <c>creative.freerepair</c></remarks>
public sealed class CreativeFreerepairCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "creative.freerepair";

    /// <summary>Reads the current value of <c>creative.freerepair</c>.</summary>
    public static CreativeFreerepairCommand CreateGet()
    {
        var cmd = CreatePackage<CreativeFreerepairCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>creative.freerepair</c> to <paramref name="value"/>.</summary>
    public static CreativeFreerepairCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CreativeFreerepairCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
