using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>&lt;gridSize&gt; 5 &lt;tileSpacing&gt; 1.35</summary>
/// <remarks>Full RCON name: <c>hexagongridgenerator.generategrid</c></remarks>
public sealed class HexagongridgeneratorGenerategridCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "hexagongridgenerator.generategrid";

    /// <summary>Creates a new <see cref="HexagongridgeneratorGenerategridCommand"/> command.</summary>
    public static HexagongridgeneratorGenerategridCommand Create()
    {
        var cmd = CreatePackage<HexagongridgeneratorGenerategridCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
