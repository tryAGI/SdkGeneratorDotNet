﻿//HintName: G.Models.ToolCallDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains the chunk of the tool call generation in the stream.
    /// </summary>
    public sealed partial class ToolCallDelta
    {
        /// <summary>
        /// Name of the tool call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Index of the tool call generated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public double Index { get; set; }

        /// <summary>
        /// Chunk of the tool parameters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public string? Parameters { get; set; }

        /// <summary>
        /// Chunk of the tool plan text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}