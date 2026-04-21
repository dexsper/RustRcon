using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in seconds between long-range detectability checks for buried objects; longer interval saves CPU for distant searches</summary>
/// <remarks>Full RCON name: <c>basemetaldetector.detectlongrangetick</c></remarks>
public sealed class BasemetaldetectorDetectlongrangetickCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basemetaldetector.detectlongrangetick";

    /// <summary>Reads the current value of <c>basemetaldetector.detectlongrangetick</c>.</summary>
    public static BasemetaldetectorDetectlongrangetickCommand CreateGet()
    {
        var cmd = CreatePackage<BasemetaldetectorDetectlongrangetickCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basemetaldetector.detectlongrangetick</c> to <paramref name="value"/>.</summary>
    public static BasemetaldetectorDetectlongrangetickCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BasemetaldetectorDetectlongrangetickCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
