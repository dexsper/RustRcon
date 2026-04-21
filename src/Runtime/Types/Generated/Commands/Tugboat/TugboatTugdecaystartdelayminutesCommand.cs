using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long until decay begins after the tugboat was last used</summary>
/// <remarks>Full RCON name: <c>tugboat.tugdecaystartdelayminutes</c></remarks>
public sealed class TugboatTugdecaystartdelayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "tugboat.tugdecaystartdelayminutes";

    /// <summary>Reads the current value of <c>tugboat.tugdecaystartdelayminutes</c>.</summary>
    public static TugboatTugdecaystartdelayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<TugboatTugdecaystartdelayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>tugboat.tugdecaystartdelayminutes</c> to <paramref name="value"/>.</summary>
    public static TugboatTugdecaystartdelayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TugboatTugdecaystartdelayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
