﻿//HintName: G.Models.MessageContentRefusalObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The refusal content generated by the assistant.
    /// </summary>
    public sealed partial class MessageContentRefusalObject
    {
        /// <summary>
        /// Always `refusal`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageContentRefusalObjectType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refusal", Required = global::Newtonsoft.Json.Required.Always)]
        public string Refusal { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}