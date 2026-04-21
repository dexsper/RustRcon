using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>fishing.overfishedarearadius</c>.</summary>
/// <remarks>Full RCON name: <c>fishing.overfishedarearadius</c></remarks>
public sealed class FishingOverfishedarearadiusCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "fishing.overfishedarearadius";

    /// <summary>Reads the current value of <c>fishing.overfishedarearadius</c>.</summary>
    public static FishingOverfishedarearadiusCommand CreateGet()
    {
        var cmd = CreatePackage<FishingOverfishedarearadiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>fishing.overfishedarearadius</c> to <paramref name="value"/>.</summary>
    public static FishingOverfishedarearadiusCommand CreateSet(float value)
    {
        var cmd = CreatePackage<FishingOverfishedarearadiusCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
