using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before a tugboat loses all its health while outside</summary>
/// <remarks>Full RCON name: <c>tugboat.tugdecayminutes</c></remarks>
public sealed class TugboatTugdecayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "tugboat.tugdecayminutes";

    /// <summary>Reads the current value of <c>tugboat.tugdecayminutes</c>.</summary>
    public static TugboatTugdecayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<TugboatTugdecayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>tugboat.tugdecayminutes</c> to <paramref name="value"/>.</summary>
    public static TugboatTugdecayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TugboatTugdecayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
