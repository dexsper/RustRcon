using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>distance cloth will simulate until</summary>
/// <remarks>Full RCON name: <c>clothlod.clothloddist</c></remarks>
public sealed class ClothlodClothloddistCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "clothlod.clothloddist";

    /// <summary>Reads the current value of <c>clothlod.clothloddist</c>.</summary>
    public static ClothlodClothloddistCommand CreateGet()
    {
        var cmd = CreatePackage<ClothlodClothloddistCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>clothlod.clothloddist</c> to <paramref name="value"/>.</summary>
    public static ClothlodClothloddistCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ClothlodClothloddistCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
