using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Allow mounting as a passenger when there's no driver</summary>
/// <remarks>Full RCON name: <c>snowmobile.allowpassengeronly</c></remarks>
public sealed class SnowmobileAllowpassengeronlyCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "snowmobile.allowpassengeronly";

    /// <summary>Reads the current value of <c>snowmobile.allowpassengeronly</c>.</summary>
    public static SnowmobileAllowpassengeronlyCommand CreateGet()
    {
        var cmd = CreatePackage<SnowmobileAllowpassengeronlyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>snowmobile.allowpassengeronly</c> to <paramref name="value"/>.</summary>
    public static SnowmobileAllowpassengeronlyCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<SnowmobileAllowpassengeronlyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
