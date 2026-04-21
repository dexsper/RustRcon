using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>petbrain.idlewhenownerofflineordead</c>.</summary>
/// <remarks>Full RCON name: <c>petbrain.idlewhenownerofflineordead</c></remarks>
public sealed class PetbrainIdlewhenownerofflineordeadCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "petbrain.idlewhenownerofflineordead";

    /// <summary>Reads the current value of <c>petbrain.idlewhenownerofflineordead</c>.</summary>
    public static PetbrainIdlewhenownerofflineordeadCommand CreateGet()
    {
        var cmd = CreatePackage<PetbrainIdlewhenownerofflineordeadCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>petbrain.idlewhenownerofflineordead</c> to <paramref name="value"/>.</summary>
    public static PetbrainIdlewhenownerofflineordeadCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PetbrainIdlewhenownerofflineordeadCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
