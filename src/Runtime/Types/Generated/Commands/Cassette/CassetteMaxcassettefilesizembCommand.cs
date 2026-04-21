using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cassette.maxcassettefilesizemb</c>.</summary>
/// <remarks>Full RCON name: <c>cassette.maxcassettefilesizemb</c></remarks>
public sealed class CassetteMaxcassettefilesizembCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cassette.maxcassettefilesizemb";

    /// <summary>Reads the current value of <c>cassette.maxcassettefilesizemb</c>.</summary>
    public static CassetteMaxcassettefilesizembCommand CreateGet()
    {
        var cmd = CreatePackage<CassetteMaxcassettefilesizembCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>cassette.maxcassettefilesizemb</c> to <paramref name="value"/>.</summary>
    public static CassetteMaxcassettefilesizembCommand CreateSet(float value)
    {
        var cmd = CreatePackage<CassetteMaxcassettefilesizembCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
