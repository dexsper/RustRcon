using System.Text;
using RustRcon.Generator.Analysis.Models;

namespace RustRcon.Generator.Emit;

/// <summary>Generates C# source files for DTO types extracted from the game assembly.</summary>
public sealed class DtoEmitter
{
    private readonly string _outputDir;

    /// <param name="outputDir">Root output directory (files are placed in <c>Dtos/</c>).</param>
    public DtoEmitter(string outputDir)
    {
        _outputDir = Path.Combine(outputDir, "Dtos");
        Directory.CreateDirectory(_outputDir);
    }

    /// <summary>Writes a <c>.cs</c> file for <paramref name="dto"/>.</summary>
    public void Emit(DtoDefinition dto)
    {
        var sb = new StringBuilder();

        sb.AppendLine("using Newtonsoft.Json;");
        sb.AppendLine();
        sb.AppendLine($"namespace {dto.Namespace};");
        sb.AppendLine();
        sb.AppendLine("/// <summary>Generated DTO — do not edit by hand.</summary>");
        sb.AppendLine($"public sealed class {dto.Name}");
        sb.AppendLine("{");

        foreach (var field in dto.Fields)
        {
            if (!string.IsNullOrWhiteSpace(field.Description))
            {
                sb.AppendLine($"    /// <summary>{EscapeXml(field.Description)}</summary>");
            }
            sb.AppendLine($"    [JsonProperty(\"{field.Name}\")]");

            var defaultValue = IsStringType(field.TypeName) ? " = string.Empty;" : string.Empty;
            sb.AppendLine($"    public {field.TypeName} {field.Name} {{ get; set; }}{defaultValue}");
            sb.AppendLine();
        }

        sb.AppendLine("}");

        var path = Path.Combine(_outputDir, $"{dto.Name}.cs");
        File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
    }

    private static bool IsStringType(string typeName) =>
        typeName is "string" or "String";

    private static string EscapeXml(string raw) =>
        raw.Replace("&", "&amp;")
           .Replace("<", "&lt;")
           .Replace(">", "&gt;");
}
