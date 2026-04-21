using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The delay globally on a server between each time a scarecrow throws a beancan (Default: 8 seconds).</summary>
/// <remarks>Full RCON name: <c>halloween.scarecrow_throw_beancan_global_delay</c></remarks>
public sealed class HalloweenScarecrowThrowBeancanGlobalDelayCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "halloween.scarecrow_throw_beancan_global_delay";

    /// <summary>Reads the current value of <c>halloween.scarecrow_throw_beancan_global_delay</c>.</summary>
    public static HalloweenScarecrowThrowBeancanGlobalDelayCommand CreateGet()
    {
        var cmd = CreatePackage<HalloweenScarecrowThrowBeancanGlobalDelayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>halloween.scarecrow_throw_beancan_global_delay</c> to <paramref name="value"/>.</summary>
    public static HalloweenScarecrowThrowBeancanGlobalDelayCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HalloweenScarecrowThrowBeancanGlobalDelayCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
