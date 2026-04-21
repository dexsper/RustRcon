using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.forceposition</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.forceposition</c></remarks>
public sealed class AntihackForcepositionCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.forceposition";

    /// <summary>Reads the current value of <c>antihack.forceposition</c>.</summary>
    public static AntihackForcepositionCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackForcepositionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.forceposition</c> to <paramref name="value"/>.</summary>
    public static AntihackForcepositionCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackForcepositionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
