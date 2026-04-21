using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, all fishing attempts succeed immediately regardless of bite probability; cheat for testing fishing catch logic</summary>
/// <remarks>Full RCON name: <c>basefishingrod.forcesuccess</c></remarks>
public sealed class BasefishingrodForcesuccessCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basefishingrod.forcesuccess";

    /// <summary>Reads the current value of <c>basefishingrod.forcesuccess</c>.</summary>
    public static BasefishingrodForcesuccessCommand CreateGet()
    {
        var cmd = CreatePackage<BasefishingrodForcesuccessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basefishingrod.forcesuccess</c> to <paramref name="value"/>.</summary>
    public static BasefishingrodForcesuccessCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BasefishingrodForcesuccessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
