using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Multiplier converting radiation material value to effective radiation damage rate; lower values reduce radiation intensity globally</summary>
/// <remarks>Full RCON name: <c>radiation.materialtoradsratio</c></remarks>
public sealed class RadiationMaterialtoradsratioCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "radiation.materialtoradsratio";

    /// <summary>Reads the current value of <c>radiation.materialtoradsratio</c>.</summary>
    public static RadiationMaterialtoradsratioCommand CreateGet()
    {
        var cmd = CreatePackage<RadiationMaterialtoradsratioCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>radiation.materialtoradsratio</c> to <paramref name="value"/>.</summary>
    public static RadiationMaterialtoradsratioCommand CreateSet(float value)
    {
        var cmd = CreatePackage<RadiationMaterialtoradsratioCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
