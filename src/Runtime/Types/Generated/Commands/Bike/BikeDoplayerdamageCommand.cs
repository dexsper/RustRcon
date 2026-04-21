using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Can bike crashes cause damage or death to the rider?</summary>
/// <remarks>Full RCON name: <c>bike.doplayerdamage</c></remarks>
public sealed class BikeDoplayerdamageCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bike.doplayerdamage";

    /// <summary>Reads the current value of <c>bike.doplayerdamage</c>.</summary>
    public static BikeDoplayerdamageCommand CreateGet()
    {
        var cmd = CreatePackage<BikeDoplayerdamageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bike.doplayerdamage</c> to <paramref name="value"/>.</summary>
    public static BikeDoplayerdamageCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BikeDoplayerdamageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
