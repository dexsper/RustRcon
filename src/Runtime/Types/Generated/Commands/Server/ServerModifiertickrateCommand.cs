using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Rate multiplier for status effect (buff/debuff) ticks; lower values slow all active modifiers such as poison, radiation sickness and warmth</summary>
/// <remarks>Full RCON name: <c>server.modifiertickrate</c></remarks>
public sealed class ServerModifiertickrateCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.modifiertickrate";

    /// <summary>Reads the current value of <c>server.modifiertickrate</c>.</summary>
    public static ServerModifiertickrateCommand CreateGet()
    {
        var cmd = CreatePackage<ServerModifiertickrateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.modifiertickrate</c> to <paramref name="value"/>.</summary>
    public static ServerModifiertickrateCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerModifiertickrateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
