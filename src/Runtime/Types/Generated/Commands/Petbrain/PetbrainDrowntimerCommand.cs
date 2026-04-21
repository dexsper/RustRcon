using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>petbrain.drowntimer</c>.</summary>
/// <remarks>Full RCON name: <c>petbrain.drowntimer</c></remarks>
public sealed class PetbrainDrowntimerCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "petbrain.drowntimer";

    /// <summary>Reads the current value of <c>petbrain.drowntimer</c>.</summary>
    public static PetbrainDrowntimerCommand CreateGet()
    {
        var cmd = CreatePackage<PetbrainDrowntimerCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>petbrain.drowntimer</c> to <paramref name="value"/>.</summary>
    public static PetbrainDrowntimerCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PetbrainDrowntimerCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
