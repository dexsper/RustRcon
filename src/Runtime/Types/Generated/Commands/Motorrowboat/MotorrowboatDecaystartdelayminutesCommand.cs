using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long until decay begins after the boat was last used</summary>
/// <remarks>Full RCON name: <c>motorrowboat.decaystartdelayminutes</c></remarks>
public sealed class MotorrowboatDecaystartdelayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "motorrowboat.decaystartdelayminutes";

    /// <summary>Reads the current value of <c>motorrowboat.decaystartdelayminutes</c>.</summary>
    public static MotorrowboatDecaystartdelayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<MotorrowboatDecaystartdelayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>motorrowboat.decaystartdelayminutes</c> to <paramref name="value"/>.</summary>
    public static MotorrowboatDecaystartdelayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<MotorrowboatDecaystartdelayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
