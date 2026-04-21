using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Amount of collision damage on a bike required to ragdoll the player</summary>
/// <remarks>Full RCON name: <c>bike.playerdamageragdolltheshold</c></remarks>
public sealed class BikePlayerdamageragdollthesholdCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bike.playerdamageragdolltheshold";

    /// <summary>Reads the current value of <c>bike.playerdamageragdolltheshold</c>.</summary>
    public static BikePlayerdamageragdollthesholdCommand CreateGet()
    {
        var cmd = CreatePackage<BikePlayerdamageragdollthesholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bike.playerdamageragdolltheshold</c> to <paramref name="value"/>.</summary>
    public static BikePlayerdamageragdollthesholdCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BikePlayerdamageragdollthesholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
