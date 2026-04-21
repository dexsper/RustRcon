using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>construction.alternativeloschecks_enabled</c>.</summary>
/// <remarks>Full RCON name: <c>construction.alternativeloschecks_enabled</c></remarks>
public sealed class ConstructionAlternativeloschecksEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "construction.alternativeloschecks_enabled";

    /// <summary>Reads the current value of <c>construction.alternativeloschecks_enabled</c>.</summary>
    public static ConstructionAlternativeloschecksEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<ConstructionAlternativeloschecksEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>construction.alternativeloschecks_enabled</c> to <paramref name="value"/>.</summary>
    public static ConstructionAlternativeloschecksEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ConstructionAlternativeloschecksEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
