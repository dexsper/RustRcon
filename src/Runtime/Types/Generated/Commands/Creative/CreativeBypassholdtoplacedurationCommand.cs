using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Bypasses bypassHoldToPlaceDuration when deploying items</summary>
/// <remarks>Full RCON name: <c>creative.bypassholdtoplaceduration</c></remarks>
public sealed class CreativeBypassholdtoplacedurationCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "creative.bypassholdtoplaceduration";

    /// <summary>Reads the current value of <c>creative.bypassholdtoplaceduration</c>.</summary>
    public static CreativeBypassholdtoplacedurationCommand CreateGet()
    {
        var cmd = CreatePackage<CreativeBypassholdtoplacedurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>creative.bypassholdtoplaceduration</c> to <paramref name="value"/>.</summary>
    public static CreativeBypassholdtoplacedurationCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CreativeBypassholdtoplacedurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
