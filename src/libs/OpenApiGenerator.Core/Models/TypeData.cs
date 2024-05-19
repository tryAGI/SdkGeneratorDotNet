using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;

namespace OpenApiGenerator.Core.Models;

public readonly record struct TypeData(
    string CSharpType,
    bool IsArray,
    ImmutableArray<string> Properties)
{
    public static TypeData Default => new(
        CSharpType: string.Empty,
        IsArray: false,
        Properties: []);

    public static TypeData FromSchema(
        KeyValuePair<string, OpenApiSchema> schema,
        Settings settings,
        params ModelData[] parents)
    {
        parents = parents ?? throw new ArgumentNullException(nameof(parents));

        var properties = ImmutableArray<string>.Empty;
        if (schema.Value.Reference?.HostDocument.ResolveReference(schema.Value.Reference) is OpenApiSchema referenceSchema)
        {
            properties = referenceSchema.Properties
                .Select(x => x.Key)
                .ToImmutableArray();
        }
        
        return new TypeData(
            CSharpType: GetCSharpType(schema, settings, parents),
            IsArray: schema.Value.Type == "array",
            Properties: properties);
    }
    
    public static string GetCSharpType(
        KeyValuePair<string, OpenApiSchema> schema,
        Settings settings,
        params ModelData[] parents)
    {
        parents = parents ?? throw new ArgumentNullException(nameof(parents));
        
        var model = ModelData.FromSchema(schema, settings, parents);
        var (type, reference) = (schema.Value.Type, schema.Value.Format) switch
        {
            ("object", _) or (null, _) when schema.Value.Reference != null =>
                ($"{ModelData.FromKey(schema.Value.Reference.Id, settings).ClassName}", true),
            ("object", _) when schema.Value.Reference == null =>
                ($"{model.ExternalClassName}", true),

            (null, _) when schema.Value.AnyOf.Any() => ("object", true),
            (null, _) when schema.Value.OneOf.Any() => ("object", true),
            (null, _) when schema.Value.AllOf.Any() => ("object", true),

            // Only Newtonsoft.Json supports EnumMemberAttribute
            ("string", _) when schema.Value.Enum.Any() && settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson =>
                ($"{(model with { Style = ModelStyle.Enumeration }).ExternalClassName}", true),
            ("string", _) when schema.Value.Enum.Any() && settings.JsonSerializerType != JsonSerializerType.NewtonsoftJson =>
                ("string", true),

            ("boolean", _) => ("bool", false),
            ("integer", "int32") => ("int", false),
            ("integer", "int64") => ("long", false),
            ("number", "float") => ("float", false),
            ("number", "double") => ("double", false),
            ("string", "byte") => ("byte", false),
            ("string", "binary") => ("byte[]", true),
            ("string", "date") => ("global::System.DateTime", false),
            ("string", "date-time") => ("global::System.DateTime", false),
            ("string", "password") => ("string", true),

            ("integer", _) => ("int", false),
            ("number", _) => ("double", false),
            ("string", _) => ("string", true),
            ("object", _) => ("object", true),
            ("array", _) when schema.Value.Items.Reference != null =>
                ($"{ModelData.FromKey(schema.Value.Items.Reference.Id, settings).ClassName}".AsArray(), true),
            ("array", _) when schema.Value.Items.Reference == null => (GetCSharpType(schema.Value.Items.WithKey(schema.Key), settings, parents.ToArray()).AsArray(), true),
            _ => throw new NotSupportedException($"Type {schema.Value.Type} is not supported."),
        };

        return schema.Value.Nullable ||
               reference && parents.Length > 0 && parents.Last().Schema.Value?.Required.Contains(schema.Key) == false
            ? type + "?"
            : type;
    }
}