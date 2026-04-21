using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, fish bite the hook immediately after casting without any wait time; cheat for testing bite response</summary>
/// <remarks>Full RCON name: <c>basefishingrod.immediatehook</c></remarks>
public sealed class BasefishingrodImmediatehookCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basefishingrod.immediatehook";

    /// <summary>Reads the current value of <c>basefishingrod.immediatehook</c>.</summary>
    public static BasefishingrodImmediatehookCommand CreateGet()
    {
        var cmd = CreatePackage<BasefishingrodImmediatehookCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basefishingrod.immediatehook</c> to <paramref name="value"/>.</summary>
    public static BasefishingrodImmediatehookCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BasefishingrodImmediatehookCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
