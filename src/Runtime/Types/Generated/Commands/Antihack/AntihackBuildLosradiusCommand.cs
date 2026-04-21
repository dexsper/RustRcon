using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.build_losradius</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.build_losradius</c></remarks>
public sealed class AntihackBuildLosradiusCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.build_losradius";

    /// <summary>Reads the current value of <c>antihack.build_losradius</c>.</summary>
    public static AntihackBuildLosradiusCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackBuildLosradiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.build_losradius</c> to <paramref name="value"/>.</summary>
    public static AntihackBuildLosradiusCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackBuildLosradiusCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
