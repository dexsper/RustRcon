using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum handcuff condition loss fraction applied per push attempt; at 0.4 the cuffs lose up to 40% condition per escape push</summary>
/// <remarks>Full RCON name: <c>handcuffs.maxconditionrepairlossonpush</c></remarks>
public sealed class HandcuffsMaxconditionrepairlossonpushCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "handcuffs.maxconditionrepairlossonpush";

    /// <summary>Reads the current value of <c>handcuffs.maxconditionrepairlossonpush</c>.</summary>
    public static HandcuffsMaxconditionrepairlossonpushCommand CreateGet()
    {
        var cmd = CreatePackage<HandcuffsMaxconditionrepairlossonpushCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>handcuffs.maxconditionrepairlossonpush</c> to <paramref name="value"/>.</summary>
    public static HandcuffsMaxconditionrepairlossonpushCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HandcuffsMaxconditionrepairlossonpushCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
