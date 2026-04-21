using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>All player placed electrical entities will receive full power without needing to be plugged into anything</summary>
/// <remarks>Full RCON name: <c>ioentity.infiniteiopower</c></remarks>
public sealed class IoentityInfiniteiopowerCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ioentity.infiniteiopower";

    /// <summary>Reads the current value of <c>ioentity.infiniteiopower</c>.</summary>
    public static IoentityInfiniteiopowerCommand CreateGet()
    {
        var cmd = CreatePackage<IoentityInfiniteiopowerCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ioentity.infiniteiopower</c> to <paramref name="value"/>.</summary>
    public static IoentityInfiniteiopowerCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<IoentityInfiniteiopowerCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
