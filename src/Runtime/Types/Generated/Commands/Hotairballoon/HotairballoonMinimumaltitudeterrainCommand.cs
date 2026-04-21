using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>hotairballoon.minimumaltitudeterrain</c>.</summary>
/// <remarks>Full RCON name: <c>hotairballoon.minimumaltitudeterrain</c></remarks>
public sealed class HotairballoonMinimumaltitudeterrainCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "hotairballoon.minimumaltitudeterrain";

    /// <summary>Reads the current value of <c>hotairballoon.minimumaltitudeterrain</c>.</summary>
    public static HotairballoonMinimumaltitudeterrainCommand CreateGet()
    {
        var cmd = CreatePackage<HotairballoonMinimumaltitudeterrainCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>hotairballoon.minimumaltitudeterrain</c> to <paramref name="value"/>.</summary>
    public static HotairballoonMinimumaltitudeterrainCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HotairballoonMinimumaltitudeterrainCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
