using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Clamp radiation multiplier to this amount of meters, -1 = ignored</summary>
/// <remarks>Full RCON name: <c>server.monumentpuzzleresetradiationmaxradiusincrease</c></remarks>
public sealed class ServerMonumentpuzzleresetradiationmaxradiusincreaseCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.monumentpuzzleresetradiationmaxradiusincrease";

    /// <summary>Reads the current value of <c>server.monumentpuzzleresetradiationmaxradiusincrease</c>.</summary>
    public static ServerMonumentpuzzleresetradiationmaxradiusincreaseCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMonumentpuzzleresetradiationmaxradiusincreaseCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.monumentpuzzleresetradiationmaxradiusincrease</c> to <paramref name="value"/>.</summary>
    public static ServerMonumentpuzzleresetradiationmaxradiusincreaseCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerMonumentpuzzleresetradiationmaxradiusincreaseCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
