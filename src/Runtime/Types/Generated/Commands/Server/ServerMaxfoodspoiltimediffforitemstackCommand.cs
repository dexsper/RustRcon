using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Maximum difference (in seconds) that two items with spoil timers can have and still be stackable</summary>
/// <remarks>Full RCON name: <c>server.maxfoodspoiltimediffforitemstack</c></remarks>
public sealed class ServerMaxfoodspoiltimediffforitemstackCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxfoodspoiltimediffforitemstack";

    /// <summary>Reads the current value of <c>server.maxfoodspoiltimediffforitemstack</c>.</summary>
    public static ServerMaxfoodspoiltimediffforitemstackCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxfoodspoiltimediffforitemstackCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxfoodspoiltimediffforitemstack</c> to <paramref name="value"/>.</summary>
    public static ServerMaxfoodspoiltimediffforitemstackCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerMaxfoodspoiltimediffforitemstackCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
