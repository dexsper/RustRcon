using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Allow all vehicles to travel to the deep sea, unless of just the whitelisted vehicles</summary>
/// <remarks>Full RCON name: <c>deepsea.allow_all_vehicles</c></remarks>
public sealed class DeepseaAllowAllVehiclesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.allow_all_vehicles";

    /// <summary>Reads the current value of <c>deepsea.allow_all_vehicles</c>.</summary>
    public static DeepseaAllowAllVehiclesCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaAllowAllVehiclesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.allow_all_vehicles</c> to <paramref name="value"/>.</summary>
    public static DeepseaAllowAllVehiclesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DeepseaAllowAllVehiclesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
