using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, asset bundles are unloaded from memory after their assets are extracted, saving memory; disable to keep bundles resident</summary>
/// <remarks>Full RCON name: <c>global.forceunloadbundles</c></remarks>
public sealed class GlobalForceunloadbundlesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.forceunloadbundles";

    /// <summary>Reads the current value of <c>global.forceunloadbundles</c>.</summary>
    public static GlobalForceunloadbundlesCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalForceunloadbundlesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.forceunloadbundles</c> to <paramref name="value"/>.</summary>
    public static GlobalForceunloadbundlesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<GlobalForceunloadbundlesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
