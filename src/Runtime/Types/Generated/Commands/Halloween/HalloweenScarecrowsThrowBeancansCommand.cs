using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Scarecrows can throw beancans (Default: true).</summary>
/// <remarks>Full RCON name: <c>halloween.scarecrows_throw_beancans</c></remarks>
public sealed class HalloweenScarecrowsThrowBeancansCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "halloween.scarecrows_throw_beancans";

    /// <summary>Reads the current value of <c>halloween.scarecrows_throw_beancans</c>.</summary>
    public static HalloweenScarecrowsThrowBeancansCommand CreateGet()
    {
        var cmd = CreatePackage<HalloweenScarecrowsThrowBeancansCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>halloween.scarecrows_throw_beancans</c> to <paramref name="value"/>.</summary>
    public static HalloweenScarecrowsThrowBeancansCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<HalloweenScarecrowsThrowBeancansCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
