using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>server.funwaterdamagethreshold</c>.</summary>
/// <remarks>Full RCON name: <c>server.funwaterdamagethreshold</c></remarks>
public sealed class ServerFunwaterdamagethresholdCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.funwaterdamagethreshold";

    /// <summary>Reads the current value of <c>server.funwaterdamagethreshold</c>.</summary>
    public static ServerFunwaterdamagethresholdCommand CreateGet()
    {
        var cmd = CreatePackage<ServerFunwaterdamagethresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.funwaterdamagethreshold</c> to <paramref name="value"/>.</summary>
    public static ServerFunwaterdamagethresholdCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerFunwaterdamagethresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
