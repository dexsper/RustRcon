using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>boatbuildingstation.autocloseplayerchecktriggercount</c>.</summary>
/// <remarks>Full RCON name: <c>boatbuildingstation.autocloseplayerchecktriggercount</c></remarks>
public sealed class BoatbuildingstationAutocloseplayerchecktriggercountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatbuildingstation.autocloseplayerchecktriggercount";

    /// <summary>Reads the current value of <c>boatbuildingstation.autocloseplayerchecktriggercount</c>.</summary>
    public static BoatbuildingstationAutocloseplayerchecktriggercountCommand CreateGet()
    {
        var cmd = CreatePackage<BoatbuildingstationAutocloseplayerchecktriggercountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatbuildingstation.autocloseplayerchecktriggercount</c> to <paramref name="value"/>.</summary>
    public static BoatbuildingstationAutocloseplayerchecktriggercountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<BoatbuildingstationAutocloseplayerchecktriggercountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
