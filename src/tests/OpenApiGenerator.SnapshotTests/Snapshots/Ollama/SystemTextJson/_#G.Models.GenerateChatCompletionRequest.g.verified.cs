﻿//HintName: G.Models.GenerateChatCompletionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request class for the chat endpoint.
    /// </summary>
    public sealed partial class GenerateChatCompletionRequest
    {
        /// <summary>
        /// The model name. 
        /// Model names follow a `model:tag` format. Some examples are `orca-mini:3b-q4_1` and `llama2:70b`. The tag is optional and, if not provided, will default to `latest`. The tag is used to identify a specific version.
        /// <br/>Example: llama2:7b
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The messages of the chat, this can be used to keep a chat memory
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// The format to return a response in. Currently the only accepted value is json.
        /// Enable JSON mode by setting the format parameter to json. This will structure the response as valid JSON.
        /// Note: it's important to instruct the model to use JSON in the prompt. Otherwise, the model may generate large amounts whitespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.GenerateChatCompletionRequestFormatJsonConverter))]
        public GenerateChatCompletionRequestFormat? Format { get; set; }

        /// <summary>
        /// Additional model parameters listed in the documentation for the Modelfile such as `temperature`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public RequestOptions? Options { get; set; }

        /// <summary>
        /// If `false` the response will be returned as a single response object, otherwise the response will be streamed as a series of objects.
        /// <br/>Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool Stream { get; set; } = true;

        /// <summary>
        /// How long (in minutes) to keep the model loaded in memory.
        /// - If set to a positive duration (e.g. 20), the model will stay loaded for the provided duration.
        /// - If set to a negative duration (e.g. -1), the model will stay loaded indefinitely.
        /// - If set to 0, the model will be unloaded immediately once finished.
        /// - If not set, the model will stay loaded for 5 minutes by default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_alive")]
        public int? KeepAlive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}