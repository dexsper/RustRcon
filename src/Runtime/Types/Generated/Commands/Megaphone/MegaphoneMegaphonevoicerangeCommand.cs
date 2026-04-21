using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>megaphone.megaphonevoicerange</c>.</summary>
/// <remarks>Full RCON name: <c>megaphone.megaphonevoicerange</c></remarks>
public sealed class MegaphoneMegaphonevoicerangeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "megaphone.megaphonevoicerange";

    /// <summary>Reads the current value of <c>megaphone.megaphonevoicerange</c>.</summary>
    public static MegaphoneMegaphonevoicerangeCommand CreateGet()
    {
        var cmd = CreatePackage<MegaphoneMegaphonevoicerangeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>megaphone.megaphonevoicerange</c> to <paramref name="value"/>.</summary>
    public static MegaphoneMegaphonevoicerangeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<MegaphoneMegaphonevoicerangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
