namespace RustRcon.Generator.Analysis.Models;

/// <summary>Holds the extracted fields/properties of a DTO type used as a command return value.</summary>
public sealed class DtoDefinition
{
    /// <summary>Simple class name, e.g. <c>PlayerInfo</c>.</summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>Namespace the DTO will be placed in inside the generated project.</summary>
    public string Namespace { get; init; } = "RustRcon.Generated.Dtos";

    /// <summary>Ordered list of fields/properties.</summary>
    public List<DtoField> Fields { get; init; } = new();
}

/// <summary>A single field or property on a <see cref="DtoDefinition"/>.</summary>
public sealed class DtoField
{
    /// <summary>C# type name, e.g. <c>string</c>, <c>int</c>, <c>float</c>.</summary>
    public string TypeName { get; init; } = "string";

    /// <summary>Property name in PascalCase.</summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>Optional XML doc comment sourced from the original struct.</summary>
    public string? Description { get; init; }
}
