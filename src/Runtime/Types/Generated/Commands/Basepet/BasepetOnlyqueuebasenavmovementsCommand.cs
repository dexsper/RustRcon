using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>basepet.onlyqueuebasenavmovements</c>.</summary>
/// <remarks>Full RCON name: <c>basepet.onlyqueuebasenavmovements</c></remarks>
public sealed class BasepetOnlyqueuebasenavmovementsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basepet.onlyqueuebasenavmovements";

    /// <summary>Reads the current value of <c>basepet.onlyqueuebasenavmovements</c>.</summary>
    public static BasepetOnlyqueuebasenavmovementsCommand CreateGet()
    {
        var cmd = CreatePackage<BasepetOnlyqueuebasenavmovementsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basepet.onlyqueuebasenavmovements</c> to <paramref name="value"/>.</summary>
    public static BasepetOnlyqueuebasenavmovementsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BasepetOnlyqueuebasenavmovementsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
