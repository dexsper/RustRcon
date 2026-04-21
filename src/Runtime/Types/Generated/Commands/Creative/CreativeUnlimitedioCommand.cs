using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Bypasses limits on IO length and points</summary>
/// <remarks>Full RCON name: <c>creative.unlimitedio</c></remarks>
public sealed class CreativeUnlimitedioCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "creative.unlimitedio";

    /// <summary>Reads the current value of <c>creative.unlimitedio</c>.</summary>
    public static CreativeUnlimitedioCommand CreateGet()
    {
        var cmd = CreatePackage<CreativeUnlimitedioCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>creative.unlimitedio</c> to <paramref name="value"/>.</summary>
    public static CreativeUnlimitedioCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CreativeUnlimitedioCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
