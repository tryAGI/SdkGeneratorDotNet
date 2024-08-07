﻿//HintName: G.Models.ChatCompletionStreamResponseDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A chat completion delta generated by streamed model responses.
    /// </summary>
    public sealed partial class ChatCompletionStreamResponseDelta
    {
        /// <summary>
        /// The contents of the chunk message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Deprecated and replaced by `tool_calls`. The name and arguments of a function that should be called, as generated by the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_call")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ChatCompletionStreamResponseDeltaFunctionCall? FunctionCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionMessageToolCallChunk>? ToolCalls { get; set; }

        /// <summary>
        /// The role of the author of this message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatCompletionStreamResponseDeltaRole? Role { get; set; }

        /// <summary>
        /// The refusal message generated by the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}