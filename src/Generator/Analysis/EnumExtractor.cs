using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RustRcon.Generator.Analysis.Models;

namespace RustRcon.Generator.Analysis;

/// <summary>
///     Finds and extracts C# enum definitions from decompiled source text.
///     Used to automatically generate enum files (e.g. <c>UserGroup</c>) that
///     are referenced by generated DTO properties.
/// </summary>
public sealed class EnumExtractor
{
    /// <summary>
    ///     Searches all values in <paramref name="decompiled"/> for an enum named
    ///     <paramref name="enumName"/> and returns its definition, or
    ///     <see langword="null"/> when not found.
    /// </summary>
    public EnumDefinition? Extract(string enumName, IReadOnlyDictionary<string, string> decompiled)
    {
        if (string.IsNullOrWhiteSpace(enumName)) return null;

        foreach (var source in decompiled.Values)
        {
            if (!source.Contains($"enum {enumName}", StringComparison.Ordinal)) continue;

            var result = ParseEnum(source, enumName);
            if (result is not null) return result;
        }

        return null;
    }

    private static EnumDefinition? ParseEnum(string source, string enumName)
    {
        var root = CSharpSyntaxTree.ParseText(source).GetRoot();
        var enumDecl = root.DescendantNodes()
            .OfType<EnumDeclarationSyntax>()
            .FirstOrDefault(e => e.Identifier.Text == enumName);

        if (enumDecl is null) return null;

        var members = enumDecl.Members
            .Select(ParseMember)
            .ToList();

        return new EnumDefinition { Name = enumName, Members = members };
    }

    private static (string Name, long? Value) ParseMember(EnumMemberDeclarationSyntax member)
    {
        if (member.EqualsValue?.Value is not LiteralExpressionSyntax literal)
            return (member.Identifier.Text, null);

        var text = literal.Token.Text.TrimEnd('u', 'U', 'l', 'L');
        long? value = long.TryParse(text, out var v) ? v : null;
        return (member.Identifier.Text, value);
    }
}