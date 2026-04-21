using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.flyhack_extrusion</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.flyhack_extrusion</c></remarks>
public sealed class AntihackFlyhackExtrusionCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.flyhack_extrusion";

    /// <summary>Reads the current value of <c>antihack.flyhack_extrusion</c>.</summary>
    public static AntihackFlyhackExtrusionCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackFlyhackExtrusionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.flyhack_extrusion</c> to <paramref name="value"/>.</summary>
    public static AntihackFlyhackExtrusionCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackFlyhackExtrusionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
