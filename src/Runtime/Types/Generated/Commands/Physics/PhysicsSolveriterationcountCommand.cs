using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The default solver iteration count permitted for any rigid bodies (default 7). Must be positive</summary>
/// <remarks>Full RCON name: <c>physics.solveriterationcount</c></remarks>
public sealed class PhysicsSolveriterationcountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.solveriterationcount";

    /// <summary>Reads the current value of <c>physics.solveriterationcount</c>.</summary>
    public static PhysicsSolveriterationcountCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsSolveriterationcountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.solveriterationcount</c> to <paramref name="value"/>.</summary>
    public static PhysicsSolveriterationcountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<PhysicsSolveriterationcountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
