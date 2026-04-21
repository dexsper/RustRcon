using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>petbrain.idlewhenownermounted</c>.</summary>
/// <remarks>Full RCON name: <c>petbrain.idlewhenownermounted</c></remarks>
public sealed class PetbrainIdlewhenownermountedCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "petbrain.idlewhenownermounted";

    /// <summary>Reads the current value of <c>petbrain.idlewhenownermounted</c>.</summary>
    public static PetbrainIdlewhenownermountedCommand CreateGet()
    {
        var cmd = CreatePackage<PetbrainIdlewhenownermountedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>petbrain.idlewhenownermounted</c> to <paramref name="value"/>.</summary>
    public static PetbrainIdlewhenownermountedCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PetbrainIdlewhenownermountedCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
