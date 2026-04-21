using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>fishing.overfishedareadurationminutes</c>.</summary>
/// <remarks>Full RCON name: <c>fishing.overfishedareadurationminutes</c></remarks>
public sealed class FishingOverfishedareadurationminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "fishing.overfishedareadurationminutes";

    /// <summary>Reads the current value of <c>fishing.overfishedareadurationminutes</c>.</summary>
    public static FishingOverfishedareadurationminutesCommand CreateGet()
    {
        var cmd = CreatePackage<FishingOverfishedareadurationminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>fishing.overfishedareadurationminutes</c> to <paramref name="value"/>.</summary>
    public static FishingOverfishedareadurationminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<FishingOverfishedareadurationminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
