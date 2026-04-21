using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many minutes before the MLRS recovers from use and can be used again</summary>
/// <remarks>Full RCON name: <c>mlrs.brokendownminutes</c></remarks>
public sealed class MlrsBrokendownminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "mlrs.brokendownminutes";

    /// <summary>Reads the current value of <c>mlrs.brokendownminutes</c>.</summary>
    public static MlrsBrokendownminutesCommand CreateGet()
    {
        var cmd = CreatePackage<MlrsBrokendownminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>mlrs.brokendownminutes</c> to <paramref name="value"/>.</summary>
    public static MlrsBrokendownminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<MlrsBrokendownminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
