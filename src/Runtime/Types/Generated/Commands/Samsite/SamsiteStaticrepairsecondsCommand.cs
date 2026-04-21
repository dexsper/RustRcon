using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>how long until static sam sites auto repair</summary>
/// <remarks>Full RCON name: <c>samsite.staticrepairseconds</c></remarks>
public sealed class SamsiteStaticrepairsecondsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "samsite.staticrepairseconds";

    /// <summary>Reads the current value of <c>samsite.staticrepairseconds</c>.</summary>
    public static SamsiteStaticrepairsecondsCommand CreateGet()
    {
        var cmd = CreatePackage<SamsiteStaticrepairsecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>samsite.staticrepairseconds</c> to <paramref name="value"/>.</summary>
    public static SamsiteStaticrepairsecondsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SamsiteStaticrepairsecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
