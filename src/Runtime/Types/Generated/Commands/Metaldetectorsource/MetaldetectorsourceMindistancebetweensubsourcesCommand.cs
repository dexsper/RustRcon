using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>metaldetectorsource.mindistancebetweensubsources</c>.</summary>
/// <remarks>Full RCON name: <c>metaldetectorsource.mindistancebetweensubsources</c></remarks>
public sealed class MetaldetectorsourceMindistancebetweensubsourcesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "metaldetectorsource.mindistancebetweensubsources";

    /// <summary>Reads the current value of <c>metaldetectorsource.mindistancebetweensubsources</c>.</summary>
    public static MetaldetectorsourceMindistancebetweensubsourcesCommand CreateGet()
    {
        var cmd = CreatePackage<MetaldetectorsourceMindistancebetweensubsourcesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>metaldetectorsource.mindistancebetweensubsources</c> to <paramref name="value"/>.</summary>
    public static MetaldetectorsourceMindistancebetweensubsourcesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<MetaldetectorsourceMindistancebetweensubsourcesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
