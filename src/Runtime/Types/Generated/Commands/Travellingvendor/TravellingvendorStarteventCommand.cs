using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Spawns a Travelling Vendor event instance; registered as travellingvendor.startevent</summary>
/// <remarks>Full RCON name: <c>travellingvendor.startevent</c></remarks>
public sealed class TravellingvendorStarteventCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "travellingvendor.startevent";

    /// <summary>Creates a new <see cref="TravellingvendorStarteventCommand"/> command.</summary>
    public static TravellingvendorStarteventCommand Create()
    {
        var cmd = CreatePackage<TravellingvendorStarteventCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
