using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>petbrain.controldistance</c>.</summary>
/// <remarks>Full RCON name: <c>petbrain.controldistance</c></remarks>
public sealed class PetbrainControldistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "petbrain.controldistance";

    /// <summary>Reads the current value of <c>petbrain.controldistance</c>.</summary>
    public static PetbrainControldistanceCommand CreateGet()
    {
        var cmd = CreatePackage<PetbrainControldistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>petbrain.controldistance</c> to <paramref name="value"/>.</summary>
    public static PetbrainControldistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PetbrainControldistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
