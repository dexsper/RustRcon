using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>petbrain.drownindeepwater</c>.</summary>
/// <remarks>Full RCON name: <c>petbrain.drownindeepwater</c></remarks>
public sealed class PetbrainDrownindeepwaterCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "petbrain.drownindeepwater";

    /// <summary>Reads the current value of <c>petbrain.drownindeepwater</c>.</summary>
    public static PetbrainDrownindeepwaterCommand CreateGet()
    {
        var cmd = CreatePackage<PetbrainDrownindeepwaterCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>petbrain.drownindeepwater</c> to <paramref name="value"/>.</summary>
    public static PetbrainDrownindeepwaterCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PetbrainDrownindeepwaterCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
