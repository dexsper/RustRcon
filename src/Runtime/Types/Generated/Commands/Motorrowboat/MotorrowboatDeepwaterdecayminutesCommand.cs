using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before a boat loses all its health while in deep water</summary>
/// <remarks>Full RCON name: <c>motorrowboat.deepwaterdecayminutes</c></remarks>
public sealed class MotorrowboatDeepwaterdecayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "motorrowboat.deepwaterdecayminutes";

    /// <summary>Reads the current value of <c>motorrowboat.deepwaterdecayminutes</c>.</summary>
    public static MotorrowboatDeepwaterdecayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<MotorrowboatDeepwaterdecayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>motorrowboat.deepwaterdecayminutes</c> to <paramref name="value"/>.</summary>
    public static MotorrowboatDeepwaterdecayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<MotorrowboatDeepwaterdecayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
