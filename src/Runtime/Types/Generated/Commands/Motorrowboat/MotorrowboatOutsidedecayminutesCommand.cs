using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before a boat loses all its health while outside. If it's in deep water, deepwaterdecayminutes is used</summary>
/// <remarks>Full RCON name: <c>motorrowboat.outsidedecayminutes</c></remarks>
public sealed class MotorrowboatOutsidedecayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "motorrowboat.outsidedecayminutes";

    /// <summary>Reads the current value of <c>motorrowboat.outsidedecayminutes</c>.</summary>
    public static MotorrowboatOutsidedecayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<MotorrowboatOutsidedecayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>motorrowboat.outsidedecayminutes</c> to <paramref name="value"/>.</summary>
    public static MotorrowboatOutsidedecayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<MotorrowboatOutsidedecayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
