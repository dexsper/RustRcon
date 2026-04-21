using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Removes all spray paint entities within a given radius of the specified world position (X Y Z)</summary>
/// <remarks>Full RCON name: <c>global.clearspraysatpositioninradius</c></remarks>
public sealed class GlobalClearspraysatpositioninradiusCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.clearspraysatpositioninradius";

    /// <summary>Creates a new <see cref="GlobalClearspraysatpositioninradiusCommand"/> command.</summary>
    public static GlobalClearspraysatpositioninradiusCommand Create(float value)
    {
        var cmd = CreatePackage<GlobalClearspraysatpositioninradiusCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
