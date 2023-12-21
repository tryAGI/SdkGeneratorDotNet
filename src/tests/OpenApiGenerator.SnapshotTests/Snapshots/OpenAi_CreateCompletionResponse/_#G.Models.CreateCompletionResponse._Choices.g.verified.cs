﻿//HintName: G.Models.CreateCompletionResponse._Choices.g.cs

#nullable enable

namespace G
{
    public sealed partial class CreateCompletionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public sealed partial class _Choices
        {
            /// <summary>
            /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,
            /// `length` if the maximum number of tokens specified in the request was reached,
            /// or `content_filter` if content was omitted due to a flag from our content filters.
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
            public required CreateCompletionResponse._Choices._FinishReasonEnum FinishReason { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("index")]
            public required int Index { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
            public required CreateCompletionResponse._Choices._Logprobs? Logprobs { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("text")]
            public required string Text { get; set; }

            [global::System.Text.Json.Serialization.JsonExtensionData]
            public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
        }
    }
}