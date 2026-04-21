using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>parachute.bypassrepack</c>.</summary>
/// <remarks>Full RCON name: <c>parachute.bypassrepack</c></remarks>
public sealed class ParachuteBypassrepackCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "parachute.bypassrepack";

    /// <summary>Reads the current value of <c>parachute.bypassrepack</c>.</summary>
    public static ParachuteBypassrepackCommand CreateGet()
    {
        var cmd = CreatePackage<ParachuteBypassrepackCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>parachute.bypassrepack</c> to <paramref name="value"/>.</summary>
    public static ParachuteBypassrepackCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ParachuteBypassrepackCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
