using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in seconds between client-side tick updates for wildlife hazard entities</summary>
/// <remarks>Full RCON name: <c>wildlifehazard.clienttickrate</c></remarks>
public sealed class WildlifehazardClienttickrateCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "wildlifehazard.clienttickrate";

    /// <summary>Reads the current value of <c>wildlifehazard.clienttickrate</c>.</summary>
    public static WildlifehazardClienttickrateCommand CreateGet()
    {
        var cmd = CreatePackage<WildlifehazardClienttickrateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>wildlifehazard.clienttickrate</c> to <paramref name="value"/>.</summary>
    public static WildlifehazardClienttickrateCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WildlifehazardClienttickrateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
