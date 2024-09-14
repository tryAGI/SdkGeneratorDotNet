﻿//HintName: JsonConverters.CompletionStream.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CompletionStreamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CompletionStream>
    {
        /// <inheritdoc />
        public override global::G.CompletionStream Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.CompletionEvent? @event = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompletionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompletionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompletionEvent).Name}");
                @event = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.StreamSentinel? sentinel = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamSentinel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamSentinel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamSentinel).Name}");
                sentinel = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.CompletionStream(
                @event,
                sentinel
                );

            if (@event != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompletionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompletionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompletionEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (sentinel != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamSentinel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamSentinel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamSentinel).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CompletionStream value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompletionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompletionEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompletionEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Event, typeInfo);
            }
            else if (value.IsSentinel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamSentinel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamSentinel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamSentinel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sentinel, typeInfo);
            }
        }
    }
}