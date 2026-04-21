using System.Text;
using RustRcon.Generator.Analysis.Models;

namespace RustRcon.Generator.Emit;

/// <summary>Generates a <c>.cs</c> source file for each extracted enum type.</summary>
public sealed class EnumEmitter
{
    private readonly string _outputDir;

    /// <param name="outputDir">Root output directory; files are placed in <c>Dtos/</c>.</param>
    public EnumEmitter(string outputDir)
    {
        _outputDir = Path.Combine(outputDir, "Dtos");
        Directory.CreateDirectory(_outputDir);
    }

    /// <summary>Writes a <c>.cs</c> enum file for <paramref name="def"/>.</summary>
    public void Emit(EnumDefinition def)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"namespace {def.Namespace};");
        sb.AppendLine();
        sb.AppendLine("/// <summary>Generated enum — do not edit by hand.</summary>");
        sb.AppendLine($"public enum {def.Name}");
        sb.AppendLine("{");

        foreach (var (name, value) in def.Members)
        {
            var valuePart = value.HasValue ? $" = {value}" : string.Empty;
            sb.AppendLine($"    {name}{valuePart},");
        }

        sb.AppendLine("}");

        var path = Path.Combine(_outputDir, $"{def.Name}.cs");
        File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
    }
}
