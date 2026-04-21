using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RustRcon.Generator.Analysis.Models;

namespace RustRcon.Generator.Analysis;

/// <summary>
///     Extracts DTO type definitions (structs/classes marked with <c>[JsonModel]</c>
///     or used as return types) from decompiled source text.
/// </summary>
public sealed class DtoExtractor
{
    private static readonly HashSet<string> PrimitiveTypes = new(StringComparer.Ordinal)
    {
        "string", "int", "long", "float", "double", "bool", "ulong",
        "String", "Int32", "Int64", "Single", "Double", "Boolean", "UInt64"
    };

    /// <summary>
    ///     Maps normalised DTO names back to the actual class name used in the
    ///     decompiled source. Required when <see cref="ReturnTypeDetector"/> renames
    ///     ambiguous nested types (e.g. <c>Output.Entry</c> → <c>ConsoleEntry</c>).
    /// </summary>
    private static readonly Dictionary<string, string> AliasToSourceName = new(StringComparer.Ordinal)
    {
        ["ConsoleEntry"] = "Entry",
    };

    /// <summary>
    ///     Attempts to extract a <see cref="DtoDefinition"/> for <paramref name="typeName"/>
    ///     from the provided decompiled source dictionary.
    /// </summary>
    /// <param name="typeName">Simple or qualified type name, e.g. <c>PlayerInfo</c> or <c>Admin.PlayerInfo</c>.</param>
    /// <param name="decompiled">Decompiled source keyed by simple class name.</param>
    public DtoDefinition? Extract(string? typeName, IReadOnlyDictionary<string, string> decompiled)
    {
        if (string.IsNullOrWhiteSpace(typeName)) return null;
        if (PrimitiveTypes.Contains(typeName)) return null;

        var baseName = StripCollectionWrapper(typeName);
        if (PrimitiveTypes.Contains(baseName)) return null;

        var simpleName = baseName.Contains('.') ? baseName[(baseName.LastIndexOf('.') + 1)..] : baseName;
        var sourceTypeName = AliasToSourceName.GetValueOrDefault(simpleName, simpleName);

        string? source = null;
        foreach (var (_, src) in decompiled)
        {
            if (ContainsTypeDefinition(src, sourceTypeName))
            {
                source = src;
                break;
            }
        }

        if (source is null) return null;

        var dto = ParseTypeDefinition(source, sourceTypeName);

        if (dto is not null && sourceTypeName != simpleName)
        {
            return new DtoDefinition
            {
                Name = simpleName,
                Namespace = dto.Namespace,
                Fields = dto.Fields,
            };
        }

        return dto;
    }

    private static string StripCollectionWrapper(string typeName)
    {
        if (typeName.EndsWith("[]", StringComparison.Ordinal))
            return typeName[..^2].Trim();

        var match = Regex.Match(typeName, @"(?:IEnumerable|List|IList)<(.+)>");
        return match.Success ? match.Groups[1].Value.Trim() : typeName;
    }

    private static bool ContainsTypeDefinition(string source, string name)
    {
        return source.Contains($"struct {name}", StringComparison.Ordinal) ||
               source.Contains($"class {name}", StringComparison.Ordinal) ||
               source.Contains($"record {name}", StringComparison.Ordinal);
    }

    private DtoDefinition? ParseTypeDefinition(string source, string typeName)
    {
        var root = CSharpSyntaxTree.ParseText(source).GetRoot();
        var typeDecl = root.DescendantNodes()
            .OfType<TypeDeclarationSyntax>()
            .FirstOrDefault(t => t.Identifier.Text == typeName);

        if (typeDecl is null) return null;

        var fields = new List<DtoField>();

        foreach (var prop in typeDecl.Members.OfType<PropertyDeclarationSyntax>())
        {
            if (!prop.Modifiers.Any(m => m.IsKind(SyntaxKind.PublicKeyword))) continue;
            fields.Add(new DtoField
            {
                TypeName = NormaliseFieldType(prop.Type.ToString()),
                Name = prop.Identifier.Text,
                Description = ExtractXmlDoc(prop),
            });
        }

        foreach (var field in typeDecl.Members.OfType<FieldDeclarationSyntax>())
        {
            if (!field.Modifiers.Any(m => m.IsKind(SyntaxKind.PublicKeyword))) continue;
            var fieldTypeName = NormaliseFieldType(field.Declaration.Type.ToString());
            foreach (var variable in field.Declaration.Variables)
            {
                fields.Add(new DtoField
                {
                    TypeName = fieldTypeName,
                    Name = ToPascalCase(variable.Identifier.Text),
                });
            }
        }

        if (fields.Count == 0) return null;

        return new DtoDefinition
        {
            Name = typeName,
            Namespace = "RustRcon.Generated.Dtos",
            Fields = fields,
        };
    }

    private static string? ExtractXmlDoc(SyntaxNode node)
    {
        var triviaList = node.GetLeadingTrivia();
        foreach (var trivia in triviaList)
        {
            if (trivia.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia))
                return trivia.ToString().Trim();
        }

        return null;
    }

    /// <summary>
    ///     Types whose qualified game names should be mapped to the simpler
    ///     names declared in <c>UnityShims.cs</c> or other runtime shims.
    /// </summary>
    private static readonly Dictionary<string, string> KnownTypeAliases = new(StringComparer.Ordinal)
    {
        ["UnityEngine.Vector3"] = "Vector3",
        ["UnityEngine.Quaternion"] = "Quaternion",
        ["UnityEngine.Color"] = "Color",
        ["UnityEngine.Color32"] = "Color32",
        ["ServerUsers.UserGroup"] = "UserGroup",
        ["UserGroup"] = "UserGroup",
    };

    private static string NormaliseFieldType(string raw)
    {
        raw = raw.Trim().Replace("global::", string.Empty);
        return KnownTypeAliases.GetValueOrDefault(raw, raw);
    }

    private static string ToPascalCase(string name)
    {
        if (string.IsNullOrEmpty(name)) return name;
        return char.ToUpperInvariant(name[0]) + name[1..];
    }
}