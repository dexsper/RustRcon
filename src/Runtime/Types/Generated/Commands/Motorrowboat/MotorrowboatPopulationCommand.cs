using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server</summary>
/// <remarks>Full RCON name: <c>motorrowboat.population</c></remarks>
public sealed class MotorrowboatPopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "motorrowboat.population";

    /// <summary>Reads the current value of <c>motorrowboat.population</c>.</summary>
    public static MotorrowboatPopulationCommand CreateGet()
    {
        var cmd = CreatePackage<MotorrowboatPopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>motorrowboat.population</c> to <paramref name="value"/>.</summary>
    public static MotorrowboatPopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<MotorrowboatPopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
