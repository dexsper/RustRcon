using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Multiplies crafting cost of firearm ammunition</summary>
/// <remarks>Full RCON name: <c>server.hardcorefirearmammunitioncraftingmultiplier</c></remarks>
public sealed class ServerHardcorefirearmammunitioncraftingmultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.hardcorefirearmammunitioncraftingmultiplier";

    /// <summary>Reads the current value of <c>server.hardcorefirearmammunitioncraftingmultiplier</c>.</summary>
    public static ServerHardcorefirearmammunitioncraftingmultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<ServerHardcorefirearmammunitioncraftingmultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.hardcorefirearmammunitioncraftingmultiplier</c> to <paramref name="value"/>.</summary>
    public static ServerHardcorefirearmammunitioncraftingmultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerHardcorefirearmammunitioncraftingmultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
