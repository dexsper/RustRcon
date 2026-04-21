using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Apply creative mode to the entire server</summary>
/// <remarks>Full RCON name: <c>creative.allusers</c></remarks>
public sealed class CreativeAllusersCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "creative.allusers";

    /// <summary>Reads the current value of <c>creative.allusers</c>.</summary>
    public static CreativeAllusersCommand CreateGet()
    {
        var cmd = CreatePackage<CreativeAllusersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>creative.allusers</c> to <paramref name="value"/>.</summary>
    public static CreativeAllusersCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CreativeAllusersCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
