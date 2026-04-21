using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>frankensteinbrain.movetowardsrate</c>.</summary>
/// <remarks>Full RCON name: <c>frankensteinbrain.movetowardsrate</c></remarks>
public sealed class FrankensteinbrainMovetowardsrateCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "frankensteinbrain.movetowardsrate";

    /// <summary>Reads the current value of <c>frankensteinbrain.movetowardsrate</c>.</summary>
    public static FrankensteinbrainMovetowardsrateCommand CreateGet()
    {
        var cmd = CreatePackage<FrankensteinbrainMovetowardsrateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>frankensteinbrain.movetowardsrate</c> to <paramref name="value"/>.</summary>
    public static FrankensteinbrainMovetowardsrateCommand CreateSet(float value)
    {
        var cmd = CreatePackage<FrankensteinbrainMovetowardsrateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
