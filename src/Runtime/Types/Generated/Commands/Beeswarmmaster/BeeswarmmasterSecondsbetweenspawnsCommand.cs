using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before a master swarm will create a child</summary>
/// <remarks>Full RCON name: <c>beeswarmmaster.secondsbetweenspawns</c></remarks>
public sealed class BeeswarmmasterSecondsbetweenspawnsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "beeswarmmaster.secondsbetweenspawns";

    /// <summary>Reads the current value of <c>beeswarmmaster.secondsbetweenspawns</c>.</summary>
    public static BeeswarmmasterSecondsbetweenspawnsCommand CreateGet()
    {
        var cmd = CreatePackage<BeeswarmmasterSecondsbetweenspawnsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>beeswarmmaster.secondsbetweenspawns</c> to <paramref name="value"/>.</summary>
    public static BeeswarmmasterSecondsbetweenspawnsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BeeswarmmasterSecondsbetweenspawnsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
