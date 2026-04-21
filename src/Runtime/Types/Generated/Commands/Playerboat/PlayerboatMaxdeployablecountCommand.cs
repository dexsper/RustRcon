using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>playerboat.maxdeployablecount</c>.</summary>
/// <remarks>Full RCON name: <c>playerboat.maxdeployablecount</c></remarks>
public sealed class PlayerboatMaxdeployablecountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.maxdeployablecount";

    /// <summary>Reads the current value of <c>playerboat.maxdeployablecount</c>.</summary>
    public static PlayerboatMaxdeployablecountCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatMaxdeployablecountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.maxdeployablecount</c> to <paramref name="value"/>.</summary>
    public static PlayerboatMaxdeployablecountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<PlayerboatMaxdeployablecountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
