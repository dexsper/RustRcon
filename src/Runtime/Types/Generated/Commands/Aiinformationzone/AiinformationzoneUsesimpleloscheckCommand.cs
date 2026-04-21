using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>aiinformationzone.usesimpleloscheck</c>.</summary>
/// <remarks>Full RCON name: <c>aiinformationzone.usesimpleloscheck</c></remarks>
public sealed class AiinformationzoneUsesimpleloscheckCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aiinformationzone.usesimpleloscheck";

    /// <summary>Reads the current value of <c>aiinformationzone.usesimpleloscheck</c>.</summary>
    public static AiinformationzoneUsesimpleloscheckCommand CreateGet()
    {
        var cmd = CreatePackage<AiinformationzoneUsesimpleloscheckCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aiinformationzone.usesimpleloscheck</c> to <paramref name="value"/>.</summary>
    public static AiinformationzoneUsesimpleloscheckCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiinformationzoneUsesimpleloscheckCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
