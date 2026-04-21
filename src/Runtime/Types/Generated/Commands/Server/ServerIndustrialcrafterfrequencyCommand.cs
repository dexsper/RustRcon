using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How often industrial crafters attempt to craft items (value is an interval measured in seconds). Setting to 0 will disable all crafting</summary>
/// <remarks>Full RCON name: <c>server.industrialcrafterfrequency</c></remarks>
public sealed class ServerIndustrialcrafterfrequencyCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.industrialcrafterfrequency";

    /// <summary>Reads the current value of <c>server.industrialcrafterfrequency</c>.</summary>
    public static ServerIndustrialcrafterfrequencyCommand CreateGet()
    {
        var cmd = CreatePackage<ServerIndustrialcrafterfrequencyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.industrialcrafterfrequency</c> to <paramref name="value"/>.</summary>
    public static ServerIndustrialcrafterfrequencyCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerIndustrialcrafterfrequencyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
