﻿#nullable enable

// ReSharper disable RedundantNameQualifier

// ReSharper disable once CheckNamespace
namespace OpenApiGenerator.JsonConverters
{
    public sealed class OneOfConverterFactorySystemTextJson :global::System.Text.Json.Serialization.JsonConverterFactory
    {
        public override bool CanConvert(global::System.Type? typeToConvert)
        {
            return typeToConvert is { IsGenericType: true } && typeToConvert.GetGenericTypeDefinition() == typeof(OneOf<,>);
        }

        public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            typeToConvert = typeToConvert ?? throw new global::System.ArgumentNullException(nameof(typeToConvert));
        
            return (global::System.Text.Json.Serialization.JsonConverter)global::System.Activator.CreateInstance(
                typeof(OneOfConverterSystemTextJson<,>).MakeGenericType(typeToConvert.GenericTypeArguments))!;
        }
    }
}