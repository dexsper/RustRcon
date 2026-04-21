using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Chance of a favourable gene being picked [0-1]. Setting this to 0 does not ensure no favourable genes are picked up, but it greatly reduces the chances.</summary>
/// <remarks>Full RCON name: <c>planterboxstatic.favourablegenechance</c></remarks>
public sealed class PlanterboxstaticFavourablegenechanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "planterboxstatic.favourablegenechance";

    /// <summary>Reads the current value of <c>planterboxstatic.favourablegenechance</c>.</summary>
    public static PlanterboxstaticFavourablegenechanceCommand CreateGet()
    {
        var cmd = CreatePackage<PlanterboxstaticFavourablegenechanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>planterboxstatic.favourablegenechance</c> to <paramref name="value"/>.</summary>
    public static PlanterboxstaticFavourablegenechanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PlanterboxstaticFavourablegenechanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
