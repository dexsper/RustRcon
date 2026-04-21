using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Default network interpolation delay in seconds applied to NPC entity movement; lower values reduce visual lag at the cost of jitter on unstable connections</summary>
/// <remarks>Full RCON name: <c>ai.defaultinterpolationdelay</c></remarks>
public sealed class AiDefaultinterpolationdelayCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.defaultinterpolationdelay";

    /// <summary>Reads the current value of <c>ai.defaultinterpolationdelay</c>.</summary>
    public static AiDefaultinterpolationdelayCommand CreateGet()
    {
        var cmd = CreatePackage<AiDefaultinterpolationdelayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.defaultinterpolationdelay</c> to <paramref name="value"/>.</summary>
    public static AiDefaultinterpolationdelayCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiDefaultinterpolationdelayCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
